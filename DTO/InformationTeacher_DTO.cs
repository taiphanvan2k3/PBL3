using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationTeacher_DTO : InformationAcc_DTO
    {
        [DisplayName("Trình độ")]
        public string TrinhDo { get; set; }
    }
}
