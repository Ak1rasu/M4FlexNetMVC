namespace ContentService.Webservice
{
    public class NewsService
    {
        public string[] GetNewsHeaders()
        {
            string url = "http://localhost:5001/news";
            using (HttpClient httpClient = new HttpsClient())
            {
                string[] result = httpClient.GetFromJsonAsync<string[]>(url).Result;
                return result;
            }
        }
    }
}
