using System.Windows;
using Zadatak_1.ViewModels;

namespace Zadatak_1.View
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
            this.DataContext = new ManagerViewModel(this);
        }

        public Manager(string userName)
        {
            InitializeComponent();
            this.DataContext = new ManagerViewModel(this, userName);
        }
    }
}
