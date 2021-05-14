using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ColinContact_AzureFunctions
{
    public static class AddContact
    {
        [FunctionName("AddContact")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "Contacts/AddContact")] HttpRequest req, ILogger log)
        {
            try
            {
                // Retrieves all necessary data for function
                StringValues UserAgent;
                req.Headers.TryGetValue("User-Agent", out UserAgent);
                string body = await new StreamReader(req.Body).ReadToEndAsync();
                var Contact = JsonConvert.DeserializeObject<Contacts>(body as string);

                Database DB = new Database();

                // Pairs contact with designated user + adds it to the database
                Contact.UserID = Convert.ToInt32(UserAgent);
                DB.Contacts.Add(Contact);
                await DB.SaveChangesAsync();

                return new OkResult();
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