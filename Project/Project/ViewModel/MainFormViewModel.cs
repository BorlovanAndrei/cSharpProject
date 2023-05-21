using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
        #region Properties

        #region Name
        private string _name;
        public string Name { 
            get { return _name; } 
            set {
                if( _name == value)
                    return;
                _name = value;

                OnPropertyChanged("Name");
            }
        }
        #endregion

        #region Id
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if(_id==value)
                    return;
                _id = value; 
                OnPropertyChanged();
            }
        }
        #endregion

        #region Location
        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                if(_location == value)
                    return;
                _location = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Phone
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                if( _phone == value)
                    return;
                _phone = value;
                OnPropertyChanged();
            }
        }
        #endregion

        //public BindingList<Shop> Shops { get; set; }
        public BindingList <Employee> Employees { get; set; }

        #endregion

        public MainFormViewModel()
        {
            //Shops = new BindingList<Shop>();
            Employees= new BindingList<Employee>();
        }

        #region Methods
        //public void AddShop()
        //{
        //    Shops.Add(new Shop(Name, Id, Location, Phone));
        //    Name = Location = Phone = string.Empty;
        //    Id = 0;
        //}

        public void AddEmployee()
        {
            Employees.Add(new Employee(Id,Name,Location, Phone));
            Name= Location = Phone = string.Empty;
            Id = 0;
        }


        #endregion



        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       
        #endregion


    }
}
