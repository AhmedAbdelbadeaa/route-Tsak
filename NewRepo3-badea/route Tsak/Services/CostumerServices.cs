using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using route_Tsak.Dto;
using route_Tsak.Models;
using route_Tsak.Repo;
using route_Tsak.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace route_Tsak.Services
{
    public class CustomerService : IcostumerServices
    {
        public readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository _customerrepo)
        {
            _customerRepository = _customerrepo;
        }
        public async Task AddCustomerAsync(Costumerdto customerDto)
        {
            var customer = new Customer();
            customer.Name = customerDto.Name;
            customer.Email = customerDto.Email;
            await _customerRepository.AddAsync(customer);
        }

        public Task DeleteCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Costumerdto> GetAllCustomers()
        {
            List<Customer> customers = _customerRepository.GetAll();
            List<Costumerdto> custom = new List<Costumerdto>();
            foreach (var customer in customers)
            {
                Costumerdto customerDto = new Costumerdto()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                };
                custom.Add(customerDto);
            }
            return custom;
        }

        public async Task<Costumerdto> GetCustomerById(int id)
        {
            var result = _customerRepository.GetById(id);
            var cus = new Costumerdto();
            cus.Name = result.Name;
            cus.Email = result.Email;
            return cus;

        }

        public Task UpdateCustomerAsync(Costumerdto customerDto)
        {
            throw new NotImplementedException();
        }
    }
}