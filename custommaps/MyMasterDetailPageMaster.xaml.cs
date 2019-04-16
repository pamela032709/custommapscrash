using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace custommaps
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class MyMasterDetailPageMaster : ContentPage
   {
      public ListView ListView;

      public MyMasterDetailPageMaster()
      {
         InitializeComponent();

         BindingContext = new MyMasterDetailPageMasterViewModel();
         ListView = MenuItemsListView;
      }

      class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
      {
         public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }

         public MyMasterDetailPageMasterViewModel()
         {
            MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
            {
                    new MyMasterDetailPageMenuItem { Id = 0, Title = "Map Page" },
                   
                });
         }

         #region INotifyPropertyChanged Implementation
         public event PropertyChangedEventHandler PropertyChanged;
         void OnPropertyChanged([CallerMemberName] string propertyName = "")
         {
            if (PropertyChanged == null)
               return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
         #endregion
      }
   }
}
