using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.JsonParse
{
    public interface IJsonParseService
    {
        string GetParsedDataList(string jsondata);
    }
}
