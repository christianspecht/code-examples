using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

namespace WpfDatabindingQuestion
{
    public class MainWindowViewModel
    {
        public ICommand MessageCommand
        {
            get
            {
                return new RelayCommand(this.ShowMessage);
            }
        }

        private void ShowMessage(object obj)
        {
            MessageBox.Show("test");
        }
    }
}
