using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCenter01.MVVM.Models;
using SystemCenter01.MVVM.Services;
using static SystemCenter01.MVVM.Models.Entities.TicketEntity;

namespace SystemCenter01.MVVM.ViewModels
{
    public partial class AddTicketViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Add Ticket";
        [ObservableProperty]

        private string firstName = string.Empty;
        [ObservableProperty]

        private string lastName = string.Empty;
        [ObservableProperty]

        private string email = string.Empty;
        [ObservableProperty]

        private string phoneNUmber = string.Empty;
        [ObservableProperty]

        private string departmentName = string.Empty;
        [ObservableProperty]

        private string streetName = string.Empty;
        [ObservableProperty]

        private string postalCode = string.Empty;
        [ObservableProperty]

        private string city = string.Empty;
        [ObservableProperty]

        private string description = string.Empty;
        [ObservableProperty]

        private DateTime dateTime;
        [ObservableProperty]

        private Status statuses;


      


        [RelayCommand]
        public async Task AddNewTicketAsync( )
        {
            var _userservice = new UserService();


            var _user = new UserModel { 
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNUmber,
                DepartmentName = departmentName,
                StreetName = streetName,
                PostalCode = postalCode,
                City = city,
                Description = description,
                DateTime = dateTime,
                Statuses = statuses


            };
            await _userservice.SaveTicketToDatabaseAsync(_user);
        }

    }
}
