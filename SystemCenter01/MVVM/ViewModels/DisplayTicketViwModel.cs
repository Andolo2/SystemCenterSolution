using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCenter01.MVVM.Models;
using SystemCenter01.MVVM.Services;
using static SystemCenter01.MVVM.Models.Entities.TicketEntity;

namespace SystemCenter01.MVVM.ViewModels
{
    public partial class DisplayTicketViwModel : ObservableObject
    {
        [ObservableProperty]
        public string title = "Display Ticket";


        [ObservableProperty]
        private ObservableCollection<UserModel> displayusers = UserService.Users();



        [ObservableProperty]
        private UserModel selectedContact = null!;






    }
}
