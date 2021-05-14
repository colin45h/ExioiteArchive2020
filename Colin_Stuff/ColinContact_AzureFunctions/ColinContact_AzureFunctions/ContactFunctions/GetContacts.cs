using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ColinContact_AzureFunctions
{
    public static class GetContacts
    {
        [FunctionName("GetContacts")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "Contacts/GetContacts")] HttpRequest req, ILogger log)
        {
            try
            {
                // Retrieves all necessary data for function
                StringValues UserAgent;
                req.Headers.TryGetValue("User-Agent", out UserAgent);

                Database DB = new Database();

                // Returns all user specific Contacts
                var Contacts = DB.Contacts.Where(x => x.UserID == Convert.ToInt32(UserAgent));

                await DB.SaveChangesAsync();

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