using System.ComponentModel;

namespace wpf16
{
    public class Nickname : INotifyPropertyChanged
    {
        string _name;
        string _nickName;

        public Nickname() : this("Name", "Nickname")
        {

        }
        public Nickname(string name, string nickName)
        {
            _name = name;
            _nickName = nickName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void Notify(string propName)
        {
            if(propName != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        
        public string Name { get { return _name; } set { _name = value; Notify( nameof(Name)); } }

        
        public string NickName { get { return _nickName; } set { _nickName = value; Notify( nameof(NickName)); } }
    }
}
