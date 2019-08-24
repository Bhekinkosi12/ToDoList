using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ToDoList.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Acerca de...";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.linkedin.com/in/alfredocastronava/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}