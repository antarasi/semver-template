using System;
using System.Collections.Generic;
using System.Text;

namespace SemverTemplate
{
    class SemVer
    {
        string[] parts;

        public SemVer(string input)
        {
            parts = input.Split(new Char[] {'.'});

            if (parts.Length != 3)
            {
                throw new Exception("Incorrect SemVer argument. Only x.x.x supported.");
            }
        }

        public string replaceInTemplate(string template) {
            return template
                .Replace(@"${MAJOR}", parts[0])
                .Replace(@"${MINOR}", parts[1])
                .Replace(@"${PATCH}", parts[2]);
        }
    }
}
