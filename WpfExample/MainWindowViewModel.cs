using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfExample
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ICommand hiButtonCommand;
        private ICommand toggleExecuteCommand { get; set; }
        private bool canExecute = true;
        public event PropertyChangedEventHandler PropertyChanged;
        public String CurrentDateString = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

        public String HiButtonContent
        {
            get { return "click to hi"; }
        }

        public String Greeting { get; set; }

        public String CurrentDate
        {
            get
            {
                return CurrentDateString;
            }
        }
        
        public bool CanExecute
        {
            get { return this.canExecute; }
            set
            {
                if (this.canExecute == value)
                { return; }
                this.canExecute = value;
            }
        }
        public ICommand ToggleExecuteCommand
        {
            get
            { return toggleExecuteCommand; }
            set
            { toggleExecuteCommand = value; }
        }
        public ICommand HiButtonCommand
        {
            get
            { return hiButtonCommand; }
            set
            { hiButtonCommand = value; }
        }
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       
        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }
        public void ShowMessage(object obj)
        {
            Greeting = obj.ToString();
            OnPropertyChanged("Greeting");
        }
        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }
    }
}
