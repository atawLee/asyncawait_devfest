public partial class Program
{
    static async Task Main(string[] args)
    {
        await CallAsync();
    }

    private static async Task CallAsync()
    {
        string title = DateTime.Now.ToString();
        string text = await GetFileContents();
        Console.WriteLine(title + ": " + text);
    }

    private static async Task<string> GetFileContents()
    {
        return await new TaskFactory().StartNew(() => { return "test"; });
    }
}