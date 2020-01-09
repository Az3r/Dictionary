using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Main.Ultilities
{
    /// <summary>
    /// Implemented binding events, including: <see cref="INotifyPropertyChanged"/>
    /// </summary>
    public class BindingUltility : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
