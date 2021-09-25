using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INSOProjectWebApplication.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INSOProjectWebApplication.Pages.Application
{
    public class LoginPageModel : PageModel
    {

        private readonly FirstContext _context;
        public LoginPageModel(FirstContext context)
        {
            _context = context;
        }


        [BindProperty]
        public String userInput { get; set; }

        [BindProperty]
        public String userPassword { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            var resultUser = _context.getUser(userPassword, userInput).Result;
            
            if (resultUser[0].countUSER != 0)   //check if the user exist 
            {
                return RedirectToPage("/Application/InstitutionPerspectivePage");
            

            }

            else
            {
                return RedirectToPage("/Application/LoginPage");


            }



        }



    }
}
