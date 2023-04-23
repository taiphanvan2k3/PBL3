using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CauHoi_DTO1
    {
        public string Poser { get; set; }
        public string AnswerTrueID { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public bool MultiQuestion { get; set; }
        public List<string> AnswerTrue { get; set; }
    }
}
