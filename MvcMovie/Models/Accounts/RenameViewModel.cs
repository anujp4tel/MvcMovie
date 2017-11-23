using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models.Accounts
{
    public class RenameViewModel
    {
        [Display(Name = "Display Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
