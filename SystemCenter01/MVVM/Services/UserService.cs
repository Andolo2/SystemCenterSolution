using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemCenter01.Context;
using SystemCenter01.MVVM.Models;
using SystemCenter01.MVVM.Models.Entities;

namespace SystemCenter01.MVVM.Services
{
    public class UserService : ObservableObject
    {
        private static DataContext _context = new DataContext(); 

        private static ObservableCollection<UserModel> _items;



        public async Task SaveTicketToDatabaseAsync(UserModel user)
        {
            var _userEntity = new UserEntity
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,

            };

            var _departmentEntity = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentName == user.DepartmentName && x.StreetName == user.StreetName && x.PostalCode == user.PostalCode && x.City == user.City);
            if(_departmentEntity != null)
            {
                _userEntity.DepartmentId =_departmentEntity.Id; // Should be _DepartmentEntity.id
            }
            else
            {
                _userEntity.Department = new DepartmentEntity
                {
                    DepartmentName = user.DepartmentName,
                    StreetName = user.StreetName,
                    PostalCode = user.PostalCode,
                    City = user.City
                };
            }

            var _ticketEntity = new TicketEntity
            {
                Description = user.Description,
                DateTime = user.DateTime,
                Statuses = user.Statuses
            };


            _context.Add(_userEntity);
            await _context.SaveChangesAsync();
        }

        public static async Task<ObservableCollection<UserModel>> GetAllAsync()
        {
            Console.WriteLine("test3");

           

            foreach (var _item in await _context.Users.Include(x => x.Department).ToListAsync())
                _items.Add(new UserModel // should be _items
                {
                   Id = _item.Id,
                   FirstName = _item.FirstName,
                   LastName = _item.LastName,
                   Email = _item.Email,
                   PhoneNumber = _item.PhoneNumber,
                   DepartmentName = _item.Department.DepartmentName,
                   StreetName = _item.Department.StreetName,
                   PostalCode = _item.Department.PostalCode,
                   City = _item.Department.PostalCode,


                });
            Console.WriteLine(_items);
            return _items;
            
        }


      

       

        


    }
}


