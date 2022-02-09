using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PaintJob.Core
{
    class ObervableObject : INotifyPropertyChanged
    {

        // use for JobMainView

        #region JobMainView EventHandler

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

    }
}
