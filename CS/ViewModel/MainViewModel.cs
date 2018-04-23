using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using RichEditBinding.Model;

namespace RichEditBinding.ViewModel {


    public class MainViewModel : INotifyPropertyChanged {
        public MainViewModel() {
            data = CreateCollection();
        }

        private ObservableCollection<Data> data;
        public ObservableCollection<Data> Data {
            get { return data; }
            set {
                if (value != this.data) {
                    this.data = value;
                    RaisePropertyChanged("Data");
                }
            }
        }

        ObservableCollection<Data> CreateCollection() {
            ObservableCollection<Data> collection = new ObservableCollection<Data>();
            collection.Add(new Data() { FormatType = FormatType.Html, Description = @"<p>sample HTML text</p>" });
            collection.Add(new Data() { FormatType = FormatType.Rtf, Description = @"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Calibri;}} {\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang9\f0\fs22 sample RTF text\par}" });
            return collection;
        }

        private Data selectedData;
        public Data SelectedData {
            get { return selectedData; }
            set {
                if (value != this.selectedData) {
                    selectedData = value;
                    RaisePropertyChanged("SelectedData");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String info) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
