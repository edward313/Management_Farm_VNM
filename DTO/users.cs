using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class users
    {

        private int id;
        private string firstname;
        private string lastname;
        private string email;
        private string adress;
        private string password;
        private int roleid;

        public users(int id, string firstname, string lastname, string email, string adress, string password, int roleid)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.adress = adress;
            this.password = password;
            this.roleid = roleid;
        }
    }


}
