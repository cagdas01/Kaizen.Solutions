using System.Text;
using System.Text.Json;
using Kaizen.JsonParse;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

 class Program
{
    static void Main(string[] args)
    {
       var provider =  new ServiceCollection().AddScoped<IJsonParseService, JsonParseService>().BuildServiceProvider();

       var JsonParseService =  provider.GetRequiredService<IJsonParseService>();

        var receiptsFullText = JsonParseService.GetParsedDataList(Constants.RECEIPTJSONDATA);

        Console.WriteLine(receiptsFullText);
    }
}






