using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Models;
using Zadatak_1.Service;
using Zadatak_1.View;

namespace Zadatak_1.ViewModels
{
    class AddEmployeeViewModel : ViewModelBase
    {
        AddEmployee addEmployee;
        Service.Service service = new Service.Service();

        #region Constructors

        public AddEmployeeViewModel(AddEmployee addEmployeeOpen)
        {
            account = new tblAccount();
            employee = new tblEmployee();
            addEmployee = addEmployeeOpen;
            engagementsList = service.GetAllEngagements();
        }

        #endregion

        #region Properties

        private string dateOfBirth;

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        private tblAccount account;

        public tblAccount Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
                OnPropertyChanged("Account");
            }
        }

        private tblEmployee employee;

        public tblEmployee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                OnPropertyChanged("Employee");
            }
        }

        private List<tblEngagement> engagementsList;

        public List<tblEngagement> EngagementsList
        {
            get { return engagementsList; }
            set
            {
                engagementsList = value;
                OnPropertyChanged("EngagementsList");
            }
        }


        #endregion

        #region Commands

        private ICommand save;

        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand.RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }

                return save;
            }
        }

        private void SaveExecute()
        {
            try
            {
                tblEmployee newEmployee = service.AddEmployee(Employee);
                MessageBox.Show("Employee saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanSaveExecute()
        {
            if (Account.FullName != null && Account.DateOfBirth != null && Account.Email != null && Account.UserName != null && Account.Pass != null
                 && Employee.HotelFloor != null && Employee.Gender != null && Employee.Cityzenship != null && employee.EngagementID > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private ICommand close;

        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand.RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }

                return close;
            }
        }

        private void CloseExecute()
        {
            try
            {
                addEmployee.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanCloseExecute()
        {
            return true;
        }

        #endregion
    }
}
