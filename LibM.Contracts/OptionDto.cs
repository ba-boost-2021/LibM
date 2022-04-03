using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Contracts
{
    public class OptionDto
    {
        public string Label { get; set; }
        public Guid Code { get; set; }
        public override string ToString()
        {
            return Label;
        }
    }
}
