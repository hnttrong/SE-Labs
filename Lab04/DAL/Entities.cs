using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("tblCustomers")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }
    }

    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, StringLength(100)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }

    [Table("tblSuppliers")]
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required, StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
    }

    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required, StringLength(100)]
        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required, StringLength(50)]
        public string City { get; set; }

        public int Age { get; set; }

        public int YearOfEnroll { get; set; }

        [StringLength(50)]
        public string Major { get; set; }

        public decimal? GPA { get; set; }
    }

    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }
    }
}
