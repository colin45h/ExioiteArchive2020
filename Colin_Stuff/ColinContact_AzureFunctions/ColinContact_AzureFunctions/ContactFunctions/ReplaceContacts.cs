using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ColinContact_AzureFunctions
{
    public static class ReplaceContacts
    {
        [FunctionName("ReplaceContacts")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "put", Route = "Contacts/ReplaceContacts")] HttpRequest req, ILogger log)
        {
            try
            {
                // Retrieves all necessary data for function
                StringValues UserAgent;
                req.Headers.TryGetValue("User-Agent", out UserAgent);
                string body = await new StreamReader(req.Body).ReadToEndAsync();
                List<Contacts> ContactReplace = JsonConvert.DeserializeObject<List<Contacts>>(body as string);

                // Sets up all Contacts to be added to database
                foreach (Contacts contact in ContactReplace)
                {
                    contact.UserID = Convert.ToInt32(UserAgent);
                    contact.ID = 0;
                }

                Database DB = new Database();

                // Removes all user specific contacts on database
                DB.Contacts.RemoveRange(DB.Contacts.Where(x => x.UserID == Convert.ToInt32(UserAgent)));
                await DB.SaveChangesAsync();

                // Adds all new contacts from file to database
                DB.Contacts.AddRange(ContactReplace);
                await DB.SaveChangesAsync();

                // Returns user specific contacts back for DataGridView refresh
                var Contacts = DB.Contacts.Where(x => x.UserID == Convert.ToInt32(UserAgent));

                return new OkObjectResult(Contacts);
            }
            catch (Exception e)
            {
                // Catches any error in function, outputs to console
                log.LogInformation(e.Message);
                log.LogInformation(e.InnerException.Message);

                return new BadRequestResult();
            }
        }
    }
}