using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContactUSForm.Models
{
    public class GoogleReCaptchaService
    {
        private readonly ReCaptchaSetting ReCaptchaSetting;
        public GoogleReCaptchaService(IOptions<ReCaptchaSetting> reCaptchaSetting)
        {
            ReCaptchaSetting = reCaptchaSetting.Value;
        }
        public virtual async Task<GoogleReCaptchaResponse> RecVer(string Token)
        {
            GoogleReCaptchaData MyData = new GoogleReCaptchaData
            {
                Secret = ReCaptchaSetting.SecretKey,
                Response = Token
            };

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?=secret{MyData.Secret}&response={MyData.Response}");
            var res = JsonConvert.DeserializeObject<GoogleReCaptchaResponse>(response);
            return res;
        }
    }
    public class GoogleReCaptchaData
    {
        public string Secret { get; set; } 
        public string Response { get; set; }
    }
    public class GoogleReCaptchaResponse
    {
        public bool Success { get; set; }
        public DateTime Challenge_ts { get; set; }
        public string hostname { get; set; }
    }
     
}
