using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCenter01.MVVM.Models;
using SystemCenter01.MVVM.Services;

namespace SystemCenter01.MVVM.ViewModels
{
    public partial class DisplayTicketViwModel : ObservableObject
    {
        [ObservableProperty]
        public string title = "Display Ticket";

        [ObservableProperty]

        private ObservableCollection<UserModel> users = UserService.Users();

        [ObservableProperty]
        private UserModel selectedContact = null!;


        [RelayCommand]

        public void Update()
        {
            
        }

    }
}
