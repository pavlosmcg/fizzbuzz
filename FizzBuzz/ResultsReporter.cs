using System.Collections.Generic;

namespace FizzBuzz
{
    public class ResultsReporter
    {
        public IDictionary<string, int> CreateReport(IEnumerable<string> results)
        {
            var report = new Dictionary<string, int> {{"integer", 0}};

            foreach (var item in results)
            {
                int integerValue;
                if (int.TryParse(item, out integerValue))
                    report["integer"]++;
                else
                {
                    int countValue;
                    if (report.TryGetValue(item, out countValue))
                        report[item]++;
                    else
                        report.Add(item, 1);
                }
            }
            return report;
        }
    }
}
