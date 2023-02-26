using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CBBAddressItem
    {
        private int id;
        private string value;

        public int Id { get => id; set => id = value; }
        public string Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return value;
        }
    }
}
