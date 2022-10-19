using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3
{
    internal class Consultant:BankWorker,InterfaceConsultant
    {
        public virtual void ChangeTelefonNumber(int id, string number)
        {
            Bank.Clients[id].TelefonNumber = number;
        }
    }
}
