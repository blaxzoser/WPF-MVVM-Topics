using Samples.MVVM.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Samples.MVVM.Model
{
    public class SuperCustomerModel : ValidatableBindableBase
    {

        private string _name;
        [Display(Name = "Name")]
        [Required]
        [StringLength(5)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);

            }
        }

    

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                SetProperty(ref _lastName, value);

                if (value == "abc")
                    base.AddError(nameof(LastName), "abc not allowed");
                else
                    base.RemoveError(nameof(LastName));
            }
        }

        private string _phone;

        [Phone]
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                SetProperty(ref _phone, value);
            }
        }

        private string _email;
        [EmailAddress]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                SetProperty(ref _email, value);
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                SetProperty(ref _age, value);
            }
        }

        private string _comments;
        [StringLength(maximumLength:10,MinimumLength =1)]
        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                SetProperty(ref _comments, value);
            }
        }
    }
}
