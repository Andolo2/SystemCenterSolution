using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCenter01.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel = new DisplayTicketViwModel();

        [RelayCommand]
        private void GoToAddTicket() => CurrentViewModel = new AddTicketViewModel();

        [RelayCommand]
        private void GoToDisplayTicket() => CurrentViewModel = new DisplayTicketViwModel();

    }
}

