using CourseApplication.BLL.Interfaces;
using CourseApplication.BLL.VMs.UserDeliveryData;
using CourseApplication.DAL.Patterns;
using CourseApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApplication.BLL.Services
{
    public class UserDeliveryDataService : IUserDeliveryDataService
    {
        public UserDeliveryDataService(IUnitOfWork db)
        {
            _db = db;
        }

        private readonly IUnitOfWork _db;

        public async Task<Guid> CreateUserDeliveryDataAsync(UserDeliveryDataCreate _userDeliveryData)
        {
            try
            {
                var userDeliveryData = new UserDeliveryData()
                {
                    UserId=_userDeliveryData.UserId,
                    PostalIndex= _userDeliveryData.PostalIndex,
                    Country = _userDeliveryData.Country,
                    Region = _userDeliveryData.Region,
                    City = _userDeliveryData.City,
                    Street = _userDeliveryData.Street,
                    House = _userDeliveryData.House,
                    Apartments = _userDeliveryData.Apartments,
                    FullName = _userDeliveryData.FullName,
                    Telephone = _userDeliveryData.Telephone
                };
                userDeliveryData = await _db.UserDeliveryData.CreateAsync(userDeliveryData);
                return userDeliveryData.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteUserDeliveryDataAsync(Guid id)
        {
            var userDeliveryData = await _db.UserDeliveryData.GetByIdAsync(id);
            if (userDeliveryData != null)
            {
                await _db.UserDeliveryData.DeleteAsync(userDeliveryData.Id);
            }
        }

        public async Task<Guid> EditUserDeliveryDataAsync(UserDeliveryDataInfo _userDeliveryData)
        {
            try
            {
                var userDeliveryData = await _db.UserDeliveryData.GetByIdAsync(_userDeliveryData.DataId);
                userDeliveryData.UserId = _userDeliveryData.UserId;
                userDeliveryData.PostalIndex = _userDeliveryData.PostalIndex;
                userDeliveryData.Country = _userDeliveryData.Country;
                userDeliveryData.Region = _userDeliveryData.Region;
                userDeliveryData.City = _userDeliveryData.City;
                userDeliveryData.Street = _userDeliveryData.Street;
                userDeliveryData.House = _userDeliveryData.House;
                userDeliveryData.Apartments = _userDeliveryData.Apartments;
                userDeliveryData.FullName = _userDeliveryData.FullName;
                userDeliveryData.Telephone = _userDeliveryData.Telephone;
                await _db.UserDeliveryData.UpdateAsync(userDeliveryData);
                return userDeliveryData.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserDeliveryDataInfo> FindUserDeliveryData(Func<UserDeliveryData, bool> expression)
        {
            try
            {
                List<UserDeliveryData> userDeliveryData;
                if (expression == null)
                {
                    userDeliveryData = _db.UserDeliveryData.GetAll().ToList();
                }
                else
                {
                    userDeliveryData = _db.UserDeliveryData.GetAll().Where(expression).ToList();
                }
                return userDeliveryData.Select(d =>
                {
                    return new UserDeliveryDataInfo()
                    {
                        DataId = d.Id,
                        UserId = d.UserId,
                        PostalIndex = d.PostalIndex,
                        Country = d.Country,
                        Region = d.Region,
                        City = d.City,
                        Street = d.Street,
                        House = d.House,
                        Apartments = d.Apartments,
                        FullName = d.FullName,
                        Telephone = d.Telephone,
                        FullAddressString = d.PostalIndex + " " + d.Country + ", " + d.Region + ", "
                        + d.City + ", " + d.Street + " " + d.House + "-" + d.Apartments + ", " + d.FullName + ", tel." + d.Telephone,
                    };
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
