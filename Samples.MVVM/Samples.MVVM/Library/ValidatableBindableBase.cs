using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Library
{
    public class ValidatableBindableBase : BindableBase, INotifyDataErrorInfo
    {
        private Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        public IEnumerable GetErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
            {
                return _errors[propertyName];
            }
            else
            {
                return null;
            }
        }

        public Dictionary<string, List<string>> GetTotalErrors()
        {
            return _errors;
        }


        public bool HasErrors
        {
            get { return (this._errors.Count > 0); }
        }

        protected override void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            base.SetProperty<T>(ref member, val, propertyName);
            ValidateProperty(propertyName, val);
        }


        private void ValidateProperty<T>(string propertyName, T value)
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            ValidationContext validationContext = new ValidationContext(this);
            validationContext.MemberName = propertyName;
            Validator.TryValidateProperty(value, validationContext, results);

            if (results.Any())
            {
                _errors[propertyName] = results.Select(c => c.ErrorMessage).ToList();
            }
            else
            {
                _errors.Remove(propertyName);
            }
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public bool IsValid
        {
            get { return !this.HasErrors; }

        }

        public void AddError(string propertyName, string error)
        {
            this._errors[propertyName] = new List<string>() { error };
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public void RemoveError(string propertyName)
        {
            if (this._errors.ContainsKey(propertyName))
                this._errors.Remove(propertyName);
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }



    }
}
