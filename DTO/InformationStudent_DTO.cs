using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InformationStudent_DTO : InformationAcc_DTO
    {
        [DisplayName("Mã CTĐT")]
        public string MaCTDT { get; set; }
    }
}
