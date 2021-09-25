using INSOProjectWebApplication.Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INSOProjectWebApplication.Pages.Services
{
    public class FirstServices
    {
        private readonly FirstContext _context;

        public FirstServices(FirstContext context)
        {
            _context = context;
        }
    }
}
