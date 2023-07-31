using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen.GenerateRandomCode
{
    public class CodeGenerator : ICodeGenerator
    {
        private static readonly HashSet<string> generatedCodes = new();
        private static readonly string charset = "ACDEFGHKLMNPRTXYZ234579";

        public HashSet<string> GenerateCodes(int count)
        {
            var generatedCodesList = new HashSet<string>();
            var random = Random.Shared;

            while (generatedCodesList.Count < count)
            {
                var codeChars = new char[8];

                for (var i = 0; i < 8; i++)
                {
                    var randomIndex = random.Next(0, charset.Length);
                    codeChars[i] = charset[randomIndex];
                }

                var code = new string(codeChars);

                if (CheckCode(code))
                {
                    generatedCodes.Add(code);
                    generatedCodesList.Add(code);
                }
            }
            return generatedCodesList;
        }

        public bool CheckCode(string code) => code.Length == 8 && code.All(c => charset.Contains(c)) && !generatedCodes.Contains(code);
    }
}
