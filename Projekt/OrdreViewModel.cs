﻿using System;
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
    class OrdreViewModel : INotifyPropertyChanged
    {
        #region MyRegion
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ObservableCollection<Ordre> OrdrerCollection { get; set; }
        public ObservableCollection<Medie> MedieCollection { get; set; }
        public ObservableCollection<Folie> FolieCollection { get; set; }    
        public int OrdreNr { get; set; }
        public Medie Medie { get; set; }
        public Medie SelectedMedie { get; set; }
        public Folie Folie { get; set; }
        public Folie SelectedFolie { get; set; }
        public string Farve { get; set; }
        public double Længde { get; set; }
        public double Bredde { get; set; }
        public int Antal { get; set; }
        public bool Laminering { get; set; }
        public bool Fragt { get; set; }
        public bool OpTil10 { get; set; }
        public bool Montering { get; set; }
        public bool Afhentes { get; set; }
        public string Kommentar { get; set; }

        public OrdreViewModel()
        {
            OrdrerCollection = new ObservableCollection<Ordre>();
            MedieCollection = new ObservableCollection<Medie>();
            FolieCollection = new ObservableCollection<Folie>();
            Medie m1 = new Medie("SUV");
            Medie m2 = new Medie("Solv");
            MedieCollection.Add(m1);
            MedieCollection.Add(m2);
            Folie f1 = new Folie("751c");
            FolieCollection.Add(f1);
        }

        public OrdreViewModel(ObservableCollection<Ordre> ordrerCollection, Medie medie, Folie folie, string farve, double længde, double bredde, int antal, bool laminering, bool fragt, bool opTil10, bool montering, bool afhentes, string kommentar)
        {
            OrdrerCollection = ordrerCollection;
            Medie = medie;
            Folie = folie;
            Farve = farve;
            Længde = længde;
            Bredde = bredde;
            Antal = antal;
            Laminering = laminering;
            Fragt = fragt;
            OpTil10 = opTil10;
            Montering = montering;
            Afhentes = afhentes;
            Kommentar = kommentar;
        }

        public void OpretOdre()
        {
            OrdrerCollection.Add(new Ordre(SelectedMedie, SelectedFolie, Farve, Længde, Bredde, Antal, Laminering, Fragt, OpTil10, Montering, Afhentes, Kommentar));
            OnPropertyChanged();
        }
    }
}
