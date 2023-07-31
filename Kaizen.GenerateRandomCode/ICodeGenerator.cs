using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.GenerateRandomCode
{
    public interface ICodeGenerator
    {
        HashSet<string> GenerateCodes(int count); 
        bool CheckCode(string code);
    }
}
