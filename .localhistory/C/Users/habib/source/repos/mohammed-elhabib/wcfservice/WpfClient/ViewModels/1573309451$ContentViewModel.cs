﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfClient.Views;

namespace WpfClient.ViewModels
{

    public class ContentViewModel : ViewModelBase
    {
      public double with { get { return _contentControl.Width + 50; } set { value= _contentControl.Width + 50; } }
        public  double height { get { return _contentControl.Height+50; } set { value = _contentControl.Height + 50; } }
        private ContentControl _contentControl  ;
        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
                MessageBox.Show(with + "");
                OnPropertyChanged("with");
                MessageBox.Show(with + "");
            }
        }
       public ContentViewModel(ContentControl contentControl) {
          this._contentControl = contentControl;
 }
    }
}