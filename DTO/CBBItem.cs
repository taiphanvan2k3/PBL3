using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CBBItem
    {
        //id này để biết được id_city hay id_district hay id_ward
        private string id;

        //Còn value tương ứng với tên của thành phố, huyện,...
        private string value;

        public string Id { get => id; set => id = value; }
        public string Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return value;
        }
    }
}
