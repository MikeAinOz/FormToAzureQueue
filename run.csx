using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, IAsyncCollector<MailChimp> outputQueueItem, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    if (req.Method.Equals(HttpMethod.Post))
    {
    var formData = await req.Content.ReadAsFormDataAsync();
    MailChimp form = new MailChimp()
        {
            Type = formData["type"],
            Id = formData["data[id]"],
            ListId = formData["data[list_id"],
            Email = formData["data[email]"]
        };

    await outputQueueItem.AddAsync(form);
    }

    return req.CreateResponse(HttpStatusCode.OK);
}
public class MailChimp
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string ListId { get; set; }
    public string Email { get; set; }

}
