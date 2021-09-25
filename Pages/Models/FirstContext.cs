using INSOProjectWebApplication.Pages.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace INSOProjectWebApplication.Pages.Models
{
    public partial class FirstContext : DbContext
    {
        public FirstContext(DbContextOptions<FirstContext> options) : base(options)
        {
        }

        /* STORE PROCEDURES */
        public DbQuery<spLoginPage> spLoginPage { get; set; }

        public async Task<List<spLoginPage>> getUser(String passwordInput, String usernameInput)
        {

            var query = @"
                        DECLARE @RC int
   
                        EXECUTE @RC = spLoginPage  
                           @password
                          ,@username";

            var strPassword = new SqlParameter("@password", passwordInput);
            var strUsername = new SqlParameter("@username", usernameInput);

            var result = await spLoginPage.FromSqlRaw(query, new object[] {strPassword, strUsername}).ToListAsync();

            return result;
        }


    }
}
