using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfClient.Lib.AttachedProperties
{
    public class IsSeclectProperty : BaseAttachedProperty<IsSeclectProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
        /*    var button = (Button)sender;
            MessageBox.Show("OnValueChanged" + button.Content);
          */ 
            var button = (Button)sender;
            if ((bool)e.NewValue)
            {
                StackPanel stack = (StackPanel)button.Parent;
                foreach (Object obj in stack.Children)
                {
               //     MessageBox.Show(obj + "");
                    if (obj is Button)
                    {
                        var bt = (obj as Button);
                 //       MessageBox.Show(bt.GetValue(IsSeclectProperty.ValueProperty) + "");
                        //  button.SetValue(IsSeclectProperty.ValueProperty, false);//.Value = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E6979"));
                        bt.SetValue(IsSeclectProperty.ValueProperty, false);
                    }
                }
                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BCCEE4"));
            }
            else {

                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E6979"));

            }
        }
        public override void OnValueUpdated(DependencyObject sender, object value)
        {
         /*   var button = (Button)sender;
            MessageBox.Show("OnValueUpdated" + button.Content);
            */
           var button = (Button)sender;
              if ((bool)value)
              {
                  StackPanel stack = (StackPanel)button.Parent;
                  foreach (Object obj in stack.Children)
                  {

              //        MessageBox.Show(obj + "");
                      if (obj is Button) {
                          var bt = (obj as Button);
                ///          MessageBox.Show(bt.GetValue(IsSeclectProperty.ValueProperty) + "");
                          //   button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E6979"));
                      //    bt.SetValue(bt.GetValue(IsSeclectProperty.ValueProperty), false);
                      }
                  }
                  button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BCCEE4"));
              }
              else
              {

                  button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5E6979"));

              }
        }
    }
}

