using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Entidad
{
    class Customer
    {
        public int Customer_Id { get; set; }
        public int Store_Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public int Address_id { get; set; }
        public string Activebool { get; set; }
        public int Create_date { get; set; }
        public string Last_update { get; set; }
        public string Active { get; set; }
    }
}
