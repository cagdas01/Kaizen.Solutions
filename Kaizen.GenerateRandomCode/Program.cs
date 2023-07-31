using Kaizen.GenerateRandomCode;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var provider = new ServiceCollection().AddScoped<ICodeGenerator, CodeGenerator>().BuildServiceProvider();

        var codeGenerator = provider.GetRequiredService<ICodeGenerator>();

        var codes = codeGenerator.GenerateCodes(1000);

        foreach (var code in codes)
        {
            Console.WriteLine(code);
        }
        Console.WriteLine("Code count :" + codes.Count);
    }
}
