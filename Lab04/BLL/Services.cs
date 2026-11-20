using DAL;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace BLL
{
    public abstract class CrudService<T> where T : class
    {
        protected readonly Repository<T> Repository = new Repository<T>();

        public List<T> GetAll() => Repository.GetAll();
        public T GetById(int id) => id > 0 ? Repository.GetById(id) : null;
        public bool Delete(int id) => id > 0 && Repository.Delete(id);
    }

    public class CustomerService : CrudService<Customer>
    {
        public void Add(Customer customer)
        {
            Validate(customer);
            Repository.Add(customer);
        }

        public bool Update(Customer customer)
        {
            Validate(customer);
            if (customer.Id <= 0) throw new ArgumentException("A valid customer ID is required.");
            return Repository.Update(customer);
        }

        private static void Validate(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            if (string.IsNullOrWhiteSpace(customer.Name)) throw new ArgumentException("Customer name is required.");
            ValidateEmail(customer.Email);
        }

        internal static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email is required.");
            try { new MailAddress(email); }
            catch (FormatException) { throw new ArgumentException("Email format is invalid."); }
        }
    }

    public class ProductService : CrudService<Product>
    {
        public void Add(Product product) { Validate(product); Repository.Add(product); }
        public bool Update(Product product)
        {
            Validate(product);
            if (product.ProductId <= 0) throw new ArgumentException("A valid product ID is required.");
            return Repository.Update(product);
        }

        private static void Validate(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (string.IsNullOrWhiteSpace(product.ProductName)) throw new ArgumentException("Product name is required.");
            if (product.Price < 0) throw new ArgumentException("Price cannot be negative.");
            if (product.Stock < 0) throw new ArgumentException("Stock cannot be negative.");
        }
    }

    public class SupplierService : CrudService<Supplier>
    {
        public void Add(Supplier supplier) { Validate(supplier); Repository.Add(supplier); }
        public bool Update(Supplier supplier)
        {
            Validate(supplier);
            if (supplier.SupplierId <= 0) throw new ArgumentException("A valid supplier ID is required.");
            return Repository.Update(supplier);
        }

        private static void Validate(Supplier supplier)
        {
            if (supplier == null) throw new ArgumentNullException(nameof(supplier));
            if (string.IsNullOrWhiteSpace(supplier.SupplierName)) throw new ArgumentException("Supplier name is required.");
            if (!string.IsNullOrWhiteSpace(supplier.Email)) CustomerService.ValidateEmail(supplier.Email);
        }
    }

    public class StudentService : CrudService<Student>
    {
        public void Add(Student student) { Validate(student); Repository.Add(student); }
        public bool Update(Student student)
        {
            Validate(student);
            if (student.StudentId <= 0) throw new ArgumentException("A valid student ID is required.");
            return Repository.Update(student);
        }

        private static void Validate(Student student)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));
            if (string.IsNullOrWhiteSpace(student.StudentName)) throw new ArgumentException("Student name is required.");
            if (string.IsNullOrWhiteSpace(student.City)) throw new ArgumentException("City is required.");
            if (student.DateOfBirth > DateTime.Today) throw new ArgumentException("Date of birth cannot be in the future.");
            if (student.Age < 0 || student.Age > 120) throw new ArgumentException("Age must be between 0 and 120.");
            if (student.YearOfEnroll < 1900 || student.YearOfEnroll > DateTime.Today.Year + 1)
                throw new ArgumentException("Enrollment year is invalid.");
            if (student.GPA.HasValue && (student.GPA < 0 || student.GPA > 4))
                throw new ArgumentException("GPA must be from 0 to 4.");
        }
    }

    public class LoginService
    {
        private readonly UserRepository _users = new UserRepository();

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return false;
            return _users.ValidateLogin(username.Trim(), password);
        }
    }
}
