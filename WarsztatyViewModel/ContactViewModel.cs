using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Warsztaty.ViewModel
{
    public class ContactViewModel
    {
        [MaxLength(20)]
        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
