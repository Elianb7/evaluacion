using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Entidad
{
    class Rental
    {
        public int Rental_Id { get; set; }
        public string Rental_Date { get; set; }
        public int Inventory_Id { get; set; }
        public int Customer_Id { get; set; }
        public string Return_Date { get; set; }
        public int Staff_Id { get; set; }
        public string Last_update { get; set; }
    }
}
