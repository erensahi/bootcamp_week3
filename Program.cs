using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
    //        CreditMenager creditMenager = new CreditMenager();
    //        creditMenager.hesapla();
    //        creditMenager.Save();
     //       creditMenager.Save();

    //        Customer customer = new Customer();
    //        customer.Id = 1;
    //        customer.city = "Ankara";

    //        CustomerMenager customerMenager = new CustomerMenager(customer);
    //        customerMenager.add();
    //        customerMenager.delete();

    //        Company company = new Company();
     //       company.TaxNumber = "100000";
    //        company.CompanyName = "Beko";
    //        company.Id = 100;

    //        Person person = new Person();
    //        person.NationalIdentity = "1453687";

    //        CustomerMenager customerMenager2 = new CustomerMenager(new Company());
        
    //       Customer c1 = new Customer();
    //       Customer C2 = new Company();
    //       Customer c3 = new Person();

            CustomerMenager customerMenager = new CustomerMenager(new Customer(), new TeacherCreditMenager());
            customerMenager.GiveCredit();

         
            Console.ReadLine();
        }
    }

    class CreditMenager
    {

        public void hesapla()
        {
            Console.WriteLine("Kredi hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi");

        }
    }

    interface ICreditMenager
    {
        void Calculate();
        void Save();
    }

    abstract class BaseCreditMenager : ICreditMenager
    {
        public abstract void Calculate();

        public void Save()
        {
            Console.WriteLine("Kredi kaydedildi.");
        }
    }
    
    class TeacherCreditMenager : BaseCreditMenager,ICreditMenager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }
    }

    class MilitaryCreditMenager : BaseCreditMenager,ICreditMenager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı");
        }      
    }

    class Customer
    {
        public int Id { get; set;}
        public String city { get; set; }
    }

    class Person : Customer
    {
        public String NationalIdentity { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }

    class Company : Customer
    {
        public String TaxNumber { get; set; }
        public String CompanyName { get; set; }
    }

    class CustomerMenager
    {

        private Customer _customer;
        private ICreditMenager _icreditMenager;
        public CustomerMenager (Customer customer,ICreditMenager icreditMenager)
        {
            _customer = customer;
            _icreditMenager = icreditMenager;
            Console.WriteLine("Müşteri nesnesi oluşturuldu.");
        }

        public void add()
        {
            Console.WriteLine("Müşteri eklendi: ");
        }

        public void delete()
        {
            Console.WriteLine("Müşteri silindi: ");
        }

        public void GiveCredit()
        {
            _icreditMenager.Calculate();
            Console.WriteLine("Kredi verildi.");
        }

    }
}
