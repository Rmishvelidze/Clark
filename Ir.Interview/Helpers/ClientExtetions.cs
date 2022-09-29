using Newtonsoft.Json;

namespace Ir.Interview.Helpers
{
    public static class ClientExtetions
    {
        public static string GetJsonData(this Task<HttpResponseMessage> responseMessage)
        {
            var data = "";
            responseMessage.Wait();
            if (responseMessage.IsCompleted)
            {
                var result = responseMessage.Result;
                if (result.IsSuccessStatusCode)
                {
                    var message = result.Content.ReadAsStringAsync();
                    message.Wait();
                    data = message.Result;
                }
            }
            return data;
        }

        public static List<T>? Deserialize<T>(this string jsonObject) =>
            JsonConvert.DeserializeObject<List<T>>(jsonObject);
    }
}
