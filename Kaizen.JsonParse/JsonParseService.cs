using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.JsonParse
{
    public class JsonParseService : IJsonParseService
    {
        public  string GetParsedDataList(string jsondata)
        {
            var receipts = JsonConvert.DeserializeObject<IEnumerable<Receipt>>(jsondata)
                                      .OrderByDescending(x => x.Y).ToArray();

            var fullText = new StringBuilder();
            fullText.AppendLine("line text");
            var index = 0;
            for (var i = 0; i < receipts.Count(); i++)
            {
                var sentences = receipts.Where(x => x.Y == receipts[i].Y)
                                        .OrderBy(x => x.X)
                                        .Select(x => x.Description);
                var result = string.Join(" ", sentences);
                fullText.AppendLine($"  {index + 1}  {result}");
                i = i + sentences.Count();
                index++;
            }

            return fullText.Replace("%", "").ToString();
        }
    }
}
