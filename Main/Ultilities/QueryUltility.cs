using System;
using System.Collections.Generic;
using System.Text;
using Main.API;
using System.Net.Http;
using System.Threading.Tasks;

namespace Main.Ultilities
{
    public static class QueryUltility
    {
        public static string CreateLemmasQuery(string word)
        {
            if (word is null) throw new ArgumentNullException($"'{nameof(word)}' cannot be null");
            if (string.IsNullOrEmpty(word)) throw new ArgumentException($"'{nameof(word)}' cannot be empty");
            if (string.IsNullOrWhiteSpace(word)) throw new ArgumentException($"'{nameof(word)}' cannot contain only whitespace");
            return $"{APIInfo.BASE_URL}/lemmas/en-gb/{word}";
        }
    }
}
