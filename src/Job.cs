using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optimizer
{
    public class Job
    {
        public string Id { get; set; }
        public DateTime RepaymentMonth { get; set; }
        public decimal RepaymentAmount { get; set; }
        public decimal ReplacementRate { get; set; }
        public Mortgage CurrentState { get; set; }
        public bool Done { get; set; }
        public decimal ResultingCost { get; set; }
    }
}
