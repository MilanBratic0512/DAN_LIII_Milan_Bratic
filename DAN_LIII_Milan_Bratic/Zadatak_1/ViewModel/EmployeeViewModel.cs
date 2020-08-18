using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Models;
using Zadatak_1.Service;
using Zadatak_1.View;

namespace Zadatak_1.ViewModels
{
    class EmployeeViewModel : ViewModelBase
    {
        Employee employee;
        Service.Service service = new Service.Service();

        #region Constructors

        public EmployeeViewModel(Employee employeeOpen)
        {
            employee = employeeOpen;
        }

        public EmployeeViewModel(Employee employeeOpen, string userName)
        {
            employee = employeeOpen;
            employeeToView = service.GetEmployee(userName);
        }

        #endregion

        #region Properties

        private tblEmployee employeeToView;

        public tblEmployee EmployeeToView
        {
            get
            {
                return employeeToView;
            }
            set
            {
                employeeToView = value;
                OnPropertyChanged("EmployeeToView");
            }
        }

        #endregion
    }
}
