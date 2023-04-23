using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Quiz_BLL
    {
        private static Quiz_BLL _Instance;
        public static Quiz_BLL Instance
        {
            get
            {
                if(_Instance == null)
                    _Instance = new Quiz_BLL();
                return _Instance;
            }
        }
        
    }
}
