using XLabs.Data;
using XMessagingCenter.SourceCode.Services.MessageService;

namespace XMessagingCenter.SourceCode.DataBase.Models
{
    public class BaseModel : ObservableObject, IMessage
    {
        private string _id;
        
        public string Id
        {
            get { return _id; }
            set
            {
                if(_id == value) return;
                _id = value;
                NotifyPropertyChanged(() => Id);
            }
        }
        
        private string _name;
        
        public string Name
        {
            get { return _name; }
            set
            {
                if (SetProperty(ref _name, value, () => Name))
                {
                    NotifyPropertyChanged(() => Name);
                }
            }
        }
    }
}
