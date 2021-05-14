using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ColinContact_AzureFunctions
{
    public static class ExistingUserCheck
    {
        [FunctionName("ExistingUserCheck")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "Users/UserCheck")] HttpRequest req, ILogger log)
        {
            try
            {
                StringValues LoginUser;
                req.Headers.TryGetValue("Login-User", out LoginUser);
                var LoginUserCheck = JsonConvert.DeserializeObject<LoginUsers>(LoginUser);

                Database DB = new Database();

                var CorrectUser = DB.Users.Where(x => x.Username == LoginUserCheck.Username);

                await DB.SaveChangesAsync();

                if (CorrectUser.Count() == 0)
                {
                    return new OkObjectResult(CorrectUser);
                }
                else
                {
                    return new BadRequestResult();
                }
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