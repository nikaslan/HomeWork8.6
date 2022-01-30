using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._6._4
{
    struct Contact
    {
        public Contact(string[] contact)
        {
            this.Name = contact[0];
            this.Street = contact[1];
            this.HouseNumber = contact[2];
            this.FlatNumber = contact[3];
            this.MobileNumber = contact[4];
            this.FlatPhone = contact[5];
        }


        #region объявление свойств
        private string Name { get; set; }
        private string Street { get; set; }
        private string HouseNumber { get; set; }
        private string FlatNumber { get; set; }
        private string MobileNumber { get; set; }
        private string FlatPhone { get; set; }
        #endregion
    }
}
