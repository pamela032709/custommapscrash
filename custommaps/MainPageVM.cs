using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TK.CustomMap;
using Xamarin.Essentials;
using TMAP = TK.CustomMap;
namespace custommaps
{
   public class MainPageVM  : INotifyPropertyChanged
   {
  
        private static Position fiji = new TMAP.Position( -18.1963936,177.6488283);
        private MapSpan _mapRegion = TMAP.MapSpan.FromCenterAndRadius(fiji, TMAP.Distance.FromKilometers(2));

        private Position _mapCenter;
        public ObservableCollection<TKCustomMapPin> _pins;
        

      public event PropertyChangedEventHandler PropertyChanged;

      public MainPageVM()
      {
       _pins = new ObservableCollection<TKCustomMapPin>();
        
      }

     
      
      
      #region MapRegion
        public TMAP.MapSpan MapRegion
        {
            get { return this._mapRegion; }
            set
            {
                if (this._mapRegion != value)
                {
                    this._mapRegion = value;
                    this.OnPropertyChanged();
                }
            }
        }
        #endregion
        
      

      
      
       void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
   }
}
