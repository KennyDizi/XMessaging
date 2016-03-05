namespace XMessagingCenter.SourceCode.DataBase.Models
{
    public class SystemMessageModel : BaseModel
    {
        private int _messageId;
        public int MesageId
        {
            get { return _messageId; }
            set { SetProperty(ref _messageId, value, () => MesageId); }
        }

        //string title, string Message, string Accept, string Cancel
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value, () => Title); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value, () => Message); }
        }

        private string _accept;
        public string Accept
        {
            get { return _accept; }
            set { SetProperty(ref _accept, value, () => Accept); }
        }

        private string _cancel;
        public string Cancel
        {
            get { return _cancel; }
            set { SetProperty(ref _cancel, value, () => Cancel); }
        }
    }
}
