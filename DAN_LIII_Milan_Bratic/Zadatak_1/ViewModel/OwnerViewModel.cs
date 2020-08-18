using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.RelayCommand;
using Zadatak_1.Service;
using Zadatak_1.View;

namespace Zadatak_1.ViewModels
{
    class OwnerViewModel : ViewModelBase
    {
        Owner owner;
        Service.Service service = new Service.Service();

        #region Constructors

        public OwnerViewModel(Owner ownerOpen)
        {
            owner = ownerOpen;
        }

        #endregion

        #region Commands

        private ICommand addEmployee;

        public ICommand AddEmployee
        {
            get
            {
                if (addEmployee == null)
                {
                    addEmployee = new RelayCommand.RelayCommand(param => AddEmployeeExecute(), param => CanAddEmployeeExecute());
                }

                return addEmployee;
            }
        }

        private void AddEmployeeExecute()
        {
            try
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanAddEmployeeExecute()
        {
            return true;
        }

        private ICommand addManager;

        public ICommand AddManager
        {
            get
            {
                if (addManager == null)
                {
                    addManager = new RelayCommand.RelayCommand(param => AddManagerExecute(), param => CanAddManagerExecute());
                }

                return addManager;
            }
        }

        private void AddManagerExecute()
        {
            try
            {
                AddManager addManager = new AddManager();
                addManager.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanAddManagerExecute()
        {
            return true;
        }

        #endregion

    }
}
