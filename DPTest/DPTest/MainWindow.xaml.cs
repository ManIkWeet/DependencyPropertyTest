using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DPTest
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window, INotifyPropertyChanged
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

      public MainWindow()
      {
         InitializeComponent();
      }
   }
}
