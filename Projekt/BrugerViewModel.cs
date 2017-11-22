using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls;
using Projekt.Annotations;

namespace Projekt
{
    class BrugerViewModel : INotifyPropertyChanged
    {
        #region MyRegion
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ObservableCollection<Bruger> Brugere { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Kodeord { get; set; }

        public BrugerViewModel()
        {
            Brugere = new ObservableCollection<Bruger>();
        }

        public BrugerViewModel(ObservableCollection<Bruger> brugere, string email, string kodeord)
        {
            this.Brugere = brugere;
            Email = email;
            Kodeord = kodeord;
        }

        public void OpretKunde()
        {
            Brugere.Add(new Bruger(Email, Kodeord));
            OnPropertyChanged();
        }

        
    }
}
