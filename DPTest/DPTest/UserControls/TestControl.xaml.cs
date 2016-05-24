using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DPTest.UserControls
{
   /// <summary>
   /// Interaction logic for TestControl.xaml
   /// </summary>
   public partial class TestControl : UserControl
   {
      #region Property DefaultNull, where the default value is null
      private bool? _defaultNullBool = false;
      private bool? DefaultNullBool
      {
         get
         {
            return _defaultNullBool;
         }
         set
         {
            _defaultNullBool = value;
         }
      }

      public object DefaultNullObject
      {
         get
         {
            return GetValue( DefaultNullObjectProperty );
         }
         set
         {
            SetValue( DefaultNullObjectProperty, value );
         }
      }
      public static readonly DependencyProperty DefaultNullObjectProperty = DependencyProperty.Register( "DefaultNullObject", typeof( object ),
                                                                    typeof( TestControl ),
                                                                    new PropertyMetadata( null, DefaultNullObjectChanged ) );
      private static void DefaultNullObjectChanged( DependencyObject d, DependencyPropertyChangedEventArgs e )
      {
         Debug.WriteLine( "DefaultNullObjectChanged called" );
         var testControl = d as TestControl;
         bool? newvalue = null;
         if ( e.NewValue is bool? )
            newvalue = (bool?)e.NewValue;
         else if ( e.NewValue != null ) {
            bool newbool;
            if ( !bool.TryParse( e.NewValue.ToString(), out newbool ) )
               return;
            newvalue = newbool;
         }
         if ( testControl != null && !testControl.DefaultNullBool.Equals( newvalue ) )
            testControl.DefaultNullBool = newvalue;
      }
      #endregion

      #region Property DefaultFalse, where the default value is false
      private bool? _defaultFalseBool = false;
      private bool? DefaultFalseBool
      {
         get
         {
            return _defaultFalseBool;
         }
         set
         {
            _defaultFalseBool = value;
         }
      }

      public object DefaultFalseObject
      {
         get
         {
            return GetValue( DefaultFalseObjectProperty );
         }
         set
         {
            SetValue( DefaultFalseObjectProperty, value );
         }
      }
      public static readonly DependencyProperty DefaultFalseObjectProperty = DependencyProperty.Register( "DefaultFalseObject", typeof( object ),
                                                                    typeof( TestControl ),
                                                                    new PropertyMetadata( (bool?)false, DefaultFalseObjectChanged ) );
      private static void DefaultFalseObjectChanged( DependencyObject d, DependencyPropertyChangedEventArgs e )
      {
         Debug.WriteLine( "DefaultFalseObjectChanged called" );
         var testControl = d as TestControl;
         bool? newvalue = null;
         if ( e.NewValue is bool? )
            newvalue = (bool?)e.NewValue;
         else if ( e.NewValue != null ) {
            bool newbool;
            if ( !bool.TryParse( e.NewValue.ToString(), out newbool ) )
               return;
            newvalue = newbool;
         }
         if ( testControl != null && !testControl.DefaultFalseBool.Equals( newvalue ) )
            testControl.DefaultFalseBool = newvalue;
      }
      #endregion

      public TestControl()
      {
         InitializeComponent();
      }
   }
}
