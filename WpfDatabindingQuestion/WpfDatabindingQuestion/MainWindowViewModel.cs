using System.Threading;
using System.Windows;
using System.Windows.Input;

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

        public ICommand DeviceCommand
        {
            get
            {
                return new RelayCommand(this.CallExternalDevice, this.IsGuiEnabled);
            }
        }

        private void ShowMessage(object obj)
        {
            // here, the buttons are disabled while the MessageBox is open
            this.disableGui = true;
            MessageBox.Show("test");
            this.disableGui = false;
        }

        private void CallExternalDevice(object obj)
        {
            // here, the buttons are NOT disabled while the app pauses
            this.disableGui = true;
            Thread.Sleep(3000);  // simulate call to external device (USB missile launcher) which takes a few seconds and pauses the app
            this.disableGui = false;
        }

        private bool IsGuiEnabled(object obj)
        {
            return !this.disableGui;
        }
    }
}
