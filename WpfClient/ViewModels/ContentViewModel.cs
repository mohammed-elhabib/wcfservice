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
        private ContentControl _contentControl;
        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
            }
        }
        private Visibility _gridVisibility=Visibility.Collapsed;
        public Visibility GridVisibility
        {
            get
            {
                return _gridVisibility;
            }
            set
            {
                _gridVisibility = value;
            }
        }
        public ContentViewModel(ContentControl contentControl) {
          this._contentControl = contentControl;
        }
    }
}
