using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TreyFunctionsAPI
{
    public static class GetContacts
    {
        [FunctionName("GetContacts")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetContacts")] HttpRequest req, ILogger log)
        {
            try
            {
                var ContactDatabase = new Database();
                var Contacts = ContactDatabase.Contacts;

                return new OkObjectResult(Contacts);
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }
    }
}
