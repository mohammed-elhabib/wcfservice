using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfClient.Lib.AttachedProperties
{
 public   class MouseBehaviourProperty:BaseAttachedProperty<MouseBehaviourProperty,bool>
    {
      
          
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var el = (UIElement)sender;
       //     el.QueryContinueDrag += new QueryContinueDragEventHandler(element_Mouse);
        }
        static void element_Mouse(object sender, QueryContinueDragEventHandler e)
        {
            FrameworkElement element = (FrameworkElement)sender;
       

            var wind = Ico.GetValue<Window>();
            if (wind.WindowState != WindowState.Maximized)
            {
              
                
            }
        }
    }
}
