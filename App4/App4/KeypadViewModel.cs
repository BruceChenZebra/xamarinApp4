using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4
{
    public class KeypadViewModel : INotifyPropertyChanged
    {
        string inputString = "";
        string displayText = "";
        char[] specialChars = { '*', '#' };
        public ICommand AddCharCommand { set; get; }
        public ICommand DeleteCharCommand { set; get; }
        string FormatText(string str)
        {
            bool hasNonNumbers = str.IndexOfAny(specialChars) != -1;
            string formatted = str;
            if (hasNonNumbers || str.Length < 4 || str.Length > 10)
            {
            }
            else if (str.Length < 8)
            {
                formatted = String.Format("{0}-{1}", str.Substring(0, 3), str.Substring(3));
            }
            else
            {
                formatted = String.Format("({0}) {1}-{2}", str.Substring(0, 3), str.Substring(3, 3), str.Substring(6));
            }
            return formatted;
        }

        public KeypadViewModel()
        {
            AddCharCommand = new Command<string>((key) => { InputString += key; });
            DeleteCharCommand = new Command(
                () => { 
                    InputString = InputString.Substring(0, InputString.Length - 1);
                }, 
                ()=>{
                    return InputString.Length > 0;
            }
            ) ;
        }

        public string InputString
        {
            set
            {
                if (inputString != value)
                {
                    inputString = value;
                    OnPropertyChanged("InputString");
                    DisplayText = FormatText(inputString);
                    ((Command)DeleteCharCommand).ChangeCanExecute();
                    
                }
            }
            get
            {
                return inputString;
            }
        }
        public string DisplayText
        {
            set
            {
                if (displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");

                }
            }
            get
            {
                return displayText;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}