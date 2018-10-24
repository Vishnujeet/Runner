using System.Linq;
using System.Text.RegularExpressions;
using static System.String;

namespace SequenceAnalysis
{
    public class FindUppercaseFinder
    {
        public string FindUppercaseLettersAsPerPattern(string inputText)
        {
            var pattern = @"[A-Z]";
            var parsedWord = Regex.Matches(inputText, pattern);
            var regexList = parsedWord.Cast<Match>().Select(match => match.Value).ToList();
            var stringList = Join(Empty, regexList);
            return Concat(stringList.OrderBy(c => c));
        }
    }
}
