using System.Collections.Generic;

namespace MicroRuleEngineCore
{
    public class RuleValue<T>
    {
        public T Value { get; set; }
        public IEnumerable<Rule> Rules { get; set; }
    }
}