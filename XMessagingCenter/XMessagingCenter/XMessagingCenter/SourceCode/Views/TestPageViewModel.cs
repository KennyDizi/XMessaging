using System.Diagnostics;
using System.Windows.Input;
using XLabs;
using XMessagingCenter.SourceCode.Views.BaseView;

namespace XMessagingCenter.SourceCode.Views
{
    public class TestPageViewModel : XBaseViewModel
    {
        private RelayCommand<string> _showAlertCommand;

        public ICommand ShowAlertCommand
            => _showAlertCommand ?? (_showAlertCommand = new RelayCommand<string>(ShowAlertCommandAlert));

        private void ShowAlertCommandAlert(string commandMode)
        {
            int mode = 1;
            int.TryParse(commandMode, out mode);
            switch (mode)
            {
                case 1:
                {
                    DisplayAlert("This is test Title", "This is test alert body. Bla bla bla....", "Bo qua");
                }
                    break;
                case 2:
                {
                    DisplayAlert("This is test Title", "This is test alert body. Bla bla bla....", "Dong y", "Bo qua");
                }
                    break;
            }

            SystemEvent += (sender, args) => { Debug.WriteLine($"Alert result is: {args.Result}, show alert with accept is: {args.ShowAlertWithAccept}"); };
        }
    }
}
