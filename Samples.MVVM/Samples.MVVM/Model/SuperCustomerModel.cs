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
    public class SuperCustomerModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {

        private string _name;
        [Required(ErrorMessage = "We need the name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    ValidateProperty("Name", value);
                }
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
                if (_lastName != value)
                {
                    _lastName = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("LastName"));
                }
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
                if (_phone != value)
                {
                    _phone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
                }

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
                if (_email != value)
                {
                    _email = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
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
                if (_age != value)
                {
                    _age = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        private string _comments;
        [StringLength(maximumLength:10,MinimumLength =5)]
        public string Commens
        {
            get
            {
                return _comments;
            }
            set
            {
                if (_comments != value)
                {
                    _comments = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Commens"));
                }
            }
        }




        private Dictionary<string, List<string>> _erros = new Dictionary<string, List<string>>();
        public bool HasErrors => _erros.Count > 0;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public IEnumerable GetErrors(string propertyName)
        {
            if(_erros.ContainsKey(propertyName))
            {
                return _erros[propertyName];
            }
            else
            {
                return null;
            }
        }

        private void ValidateProperty(string propertyName, object value)
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            ValidationContext validationContext = new ValidationContext(this);
            validationContext.MemberName = propertyName;
            Validator.TryValidateProperty(value, validationContext, results);
           if (_erros.Any())
            {
                _erros[propertyName] = results.Select(c => c.ErrorMessage).ToList();
            }
           else
           {
                _erros.Remove(propertyName);
           }
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }


    }
}
