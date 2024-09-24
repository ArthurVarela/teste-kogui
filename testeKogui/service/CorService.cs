
using Newtonsoft.Json;
using testeKogui.models;

namespace testeKogui.service
{
    internal class CorService
    {
        static HttpClient client = new HttpClient();

        public async Task<CorResponse> GetColorNameAsync(string hexCode)
        {
            HttpResponseMessage response = await client.GetAsync($"https://www.thecolorapi.com/id?hex={hexCode}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<CorResponse>(jsonString);

            if (jsonObject != null) return jsonObject;

            return null;

        }
    }
}