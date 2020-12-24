using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Annamalai_Sharavanan.Models
{
    public class RegisterView : RegisterForm
    {
        private RegisterForm details;

        public RegisterView(RegisterForm details)
        {
            this.FirstName = FirstName;
        }

        public List<string> StateOptions { get; set; }
    }
}
