using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CS3750Final.Pages
{
    public class Tracker : PageModel
    {
        private readonly ILogger<Tracker> _logger;

        public Tracker(ILogger<Tracker> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void dostuff()
        {
            var connection = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            
        }
    }
}
