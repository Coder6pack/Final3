using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class TraiCayBUS
    {
        TraiCay traicays = new TraiCay();
        public List<TraiCayDTO> loadTraiCay()
        {
            return traicays.loadTraiCay();
        }

        public bool suaTraiCay(TraiCayDTO traicay)
        {
            return traicays.suaTraiCay(traicay);
        }
    }
}
