using Xamarin.Forms;
using XMessagingCenter.SourceCode.DataBase.Models;
using XMessagingCenter.SourceCode.Services.MessageService;

namespace XMessagingCenter.SourceCode.Views.BaseView
{
    public class XBaseView : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            FormsMessengerService.Instance.Subscribe<SystemMessageModel>(this, OnMessageReceive);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            FormsMessengerService.Instance.Unsubscribe<SystemMessageModel>(this);
        }

        private async void OnMessageReceive(object sender, SystemMessageModel message)
        {
            var result = false;
            var showAlertWithAccept = false;
            switch (message.MesageId)
            {
                case (int)XSystemMessageId.ShowAlert:
                {
                        //do some thing
                    if (string.IsNullOrEmpty(message.Accept))
                    {
                        await DisplayAlert(message.Title, message.Message, message.Cancel);
                    }
                    else
                    {
                        result = await DisplayAlert(message.Title, message.Message, message.Accept, message.Cancel);
                        showAlertWithAccept = true;
                    }
                }
                    break;
            }
            var args = new XSystemEvent(result, showAlertWithAccept);
            var bindingContext = BindingContext as XBaseViewModel;
            bindingContext?.RaiseSystemEvent(this, args);
        }
    }
}
