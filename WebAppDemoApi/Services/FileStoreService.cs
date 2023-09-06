namespace WebAppDemoApi.Services
{
    public class FileStoreService
    {
        const string baseDirectory = "d:/demo/";

        

        public string ReadFile(string filename) 
        {
            return File.ReadAllText($"{baseDirectory}{filename}");
        }
        public async Task<string> ReadFileAsync(string filename) 
        {
             return await File.ReadAllTextAsync($"{baseDirectory}{filename}");

        }
        public void SaveFile(string filename, string text) 
        {
            File.WriteAllText($"{baseDirectory}{filename}", text);
        }
    }
}
