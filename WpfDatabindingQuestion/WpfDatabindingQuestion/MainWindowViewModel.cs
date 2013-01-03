using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

namespace WpfDatabindingQuestion
{
    public class MainWindowViewModel
    {
        private bool disableGui;

        public ICommand MessageCommand
        {
            get
            {
                return new RelayCommand(this.ShowMessage, this.IsGuiEnabled);
            }
        }

        private void ShowMessage(object obj)
        {
            this.disableGui = true;
            MessageBox.Show("test");
            this.disableGui = false;
        }

        private bool IsGuiEnabled(object obj)
        {
            return !this.disableGui;
        }
    }
}
