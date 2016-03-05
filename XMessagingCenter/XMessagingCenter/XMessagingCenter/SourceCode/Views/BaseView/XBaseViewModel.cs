using System;
using XLabs.Data;
using XMessagingCenter.SourceCode.DataBase.Models;
using XMessagingCenter.SourceCode.Services.MessageService;

namespace XMessagingCenter.SourceCode.Views.BaseView
{
    public class XBaseViewModel : ObservableObject
    {
        #region events

        public event EventHandler<XSystemEvent> SystemEvent;

        public void RaiseSystemEvent(object sender, XSystemEvent systemEvent)
        {
            SystemEvent?.Invoke(sender, systemEvent);
        }

        public void DisplayAlert(string title, string message, string cancel)
        {
            FormsMessengerService.Instance.Send(new SystemMessageModel
            {
                Title = title,
                Message = message,
                Cancel = cancel,
                MesageId = (int)XSystemMessageId.ShowAlert
            });
        }

        public void DisplayAlert(string title, string message, string accept, string cancel)
        {
            FormsMessengerService.Instance.Send(new SystemMessageModel
            {
                Title = title,
                Message = message,
                Accept = accept,
                Cancel = cancel,
                MesageId = (int)XSystemMessageId.ShowAlert
            });
        }
        #endregion
    }
}
