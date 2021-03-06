﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Model
{
    public class CustomerModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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

        private int? _phone;
        public int? Phone
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

        private bool _isAlive;
        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                if (_isAlive != value)
                {
                    _isAlive = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("IsAlive"));
                }

            }
        }




        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
