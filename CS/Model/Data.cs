using System;
using System.Collections.Generic;
using System.Linq;
using RichEditBinding.ViewModel;
using System.ComponentModel;

namespace RichEditBinding.Model {

    public enum FormatType {
        Undefined, Html, Rtf
    }

    public class Data : INotifyPropertyChanged {
        public Data() { }

        string description = string.Empty;
        FormatType formatType = FormatType.Undefined;

        public string Description {
            get { return description; }
            set {
                if (value != this.description) {
                    this.description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        public FormatType FormatType {
            get { return formatType; }
            set {
                if (value != this.formatType) {
                    this.formatType = value;
                    NotifyPropertyChanged("FormatType");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
