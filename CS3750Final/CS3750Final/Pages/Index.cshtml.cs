using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CS3750Final.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            //UserObj.Salt = salt.salt();

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //if (UserObj.Id == 0) // means a brand new category
            //{
            //    _unitOfWork.User.Add(UserObj);
            //}

            //else
            //{
            //    _unitOfWork.User.Update(UserObj);
            //}

            //_unitOfWork.Save();
            return RedirectToPage("./tracker");
        }
    }
}
