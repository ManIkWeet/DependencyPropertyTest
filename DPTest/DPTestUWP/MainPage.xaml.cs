using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DPTestUWP
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page, INotifyPropertyChanged
   {
      private bool? _stata = null;
      public bool? Stata
      {
         get { return _stata; }
         set
         {
            _stata = value;
            OnPropertyChanged();
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;
      private void OnPropertyChanged( [CallerMemberName] string propertyName = null )
      {
         PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
      }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         Stata = false;
      }

      private void Button_Click_1( object sender, RoutedEventArgs e )
      {
         Stata = null;
      }

      private void Button_Click_2( object sender, RoutedEventArgs e )
      {
         Stata = true;
      }

      public MainPage()
      {
         this.InitializeComponent();
      }
   }
}
