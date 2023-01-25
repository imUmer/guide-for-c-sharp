class Async {

    public async Task<string> GetDataAsync() {
    var httpClient = new HttpClient();
    var result = await httpClient.GetStringAsync("https://learn.microsoft.com/en-us/dotnet/csharp/async");
    return result;
}

}
