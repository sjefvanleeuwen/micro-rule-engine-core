using System.Collections.Generic;
using System.Linq;

namespace MicroRuleEngineCore
{
    public class Rule
    {
        public Rule()
        {
            Inputs = Enumerable.Empty<object>();
        }

        public string MemberName { get; set; }
        public string Operator { get; set; }
        public string TargetValue { get; set; }
        public IEnumerable<Rule> Rules { get; set; }
        public IEnumerable<object> Inputs { get; set; }
    }
}