using System;

namespace XMessagingCenter.SourceCode.Services.MessageService
{
    public class XSystemEvent : EventArgs
    {
        public bool Result { get; }
        public bool ShowAlertWithAccept { get; }
        public XSystemEvent(bool result)
        {
            Result = result;
        }

        public XSystemEvent(bool result, bool showAlertWithAccept)
        {
            Result = result;
            ShowAlertWithAccept = showAlertWithAccept;
        }
    }
}
