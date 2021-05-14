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
    public static class AddUser
    {
        [FunctionName("AddUser")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "Users/AddUser")] HttpRequest req, ILogger log)
        {
            try
            {
                string body = await new StreamReader(req.Body).ReadToEndAsync();
                var User = JsonConvert.DeserializeObject<Users>(body as string);

                Database DB = new Database();

                DB.Users.Add(User);

                await DB.SaveChangesAsync();

                return new OkResult();
            }
            catch (Exception e)
            {
                log.LogInformation(e.Message);
                log.LogInformation(e.InnerException.Message);
                return new BadRequestResult();
            }
        }
    }
}