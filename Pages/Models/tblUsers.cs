using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INSOProjectWebApplication.Pages.Models
{
    public class tblUsers
    {
        public int user_id { get; set; }
        public string strName { get; set; }
        public string strLastName { get; set; }
        public string strEmail { get; set; }
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public string strUserType { get; set; }

     /*   public tblUsers()
        {
            this.user_id = 3;
            this.strName = "";
            this.strLastName = "";
            this.strEmail = "";
            this.strUsername = "";
            this.strPassword = "";
            this.strUserType = "";
        }*/


    }
}
