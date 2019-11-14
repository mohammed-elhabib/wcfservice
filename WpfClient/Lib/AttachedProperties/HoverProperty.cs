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
    public class HoverProperty : BaseAttachedProperty<HoverProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var button = (Button)sender;
            if ((bool)e.NewValue)
            {
                var colorbacground = button.Background;
                button.Background = button.Foreground;
                button.Foreground = colorbacground;
            }
        }
/*        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            var button = (Button)sender;
            if ((bool)value)
            {
                MessageBox.Show("on update");
                var colorbacground = button.Background;
                button.Background = button.Foreground;
                button.Foreground = colorbacground;
            }
        }*/
    }
}
