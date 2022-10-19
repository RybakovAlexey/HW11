using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11_3
{
    interface InterfaceManager
    {
        public void ChangePassportNumber(int id, string number);


        public void ChangeFullName(int id, string fullName);


        public void AddClient(string fullName,
            string telefonNumber,
            string pasportNumber,
            string dataChange,
            string whoChange,
            string whatChange);
   

        public void DelClient(int id);

    }
}
