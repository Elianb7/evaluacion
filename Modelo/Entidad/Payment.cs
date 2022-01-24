using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Entidad
{
    class Payment
    {
        public int Paymet_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Staff_Id { get; set; }
        public int Rental_Id { get; set; }
        public string Amount { get; set; }
        public int Payment_Date { get; set; }
    }
}
