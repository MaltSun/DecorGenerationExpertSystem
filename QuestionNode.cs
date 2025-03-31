using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTry
{
    internal class QuestionNode
    {
        public string Question { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public QuestionNode YesBranch { get; set; }
        public QuestionNode NoBranch { get; set; }
    }


}
