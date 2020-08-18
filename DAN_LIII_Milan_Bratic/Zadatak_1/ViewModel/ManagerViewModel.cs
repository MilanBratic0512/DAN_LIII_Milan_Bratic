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
    class ManagerViewModel : ViewModelBase
    {
        Manager manager;
        Service.Service service = new Service.Service();

        #region Constructors

        public ManagerViewModel(Manager managerOpen)
        {
            manager = managerOpen;
        }

        public ManagerViewModel(Manager managerOpen, string userName)
        {
            manager = managerOpen;
            managerToView = service.GetManager(userName);
        }

        #endregion

        #region Properties

        private tblManager managerToView;

        public tblManager ManagerToView
        {
            get
            {
                return managerToView;
            }
            set
            {
                managerToView = value;
                OnPropertyChanged("ManagerToView");
            }
        }

        #endregion
    }
}
