public class Customer
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
}

public class OrderProduct
{
    public string NameProduct { get; set; }
    public DateTime OrderDate { get; set; }
}

public class AdressCust
{
    public string Street { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }
}

class AllCustomers : Customer { }
class AllAddress : AdressCust { }
class AllProduct : OrderProduct { }
class USACustomer : Customer { }
class USAAddress : AdressCust { }
class USAProduct : OrderProduct { }
class GBCustomer : Customer { }
class GBAddress : AdressCust { }
class GBProduct : OrderProduct { }

class AddAll
{
    public Customer AddCust()
    {
        var customer = new AllCustomers();
        customer.Name = "Adam";
        customer.Surname = "Kaźierczyk";
        customer.PhoneNumber = "1234567890";
        return customer;
    }
    public AdressCust AddAddress()
    {
        var address = new AllAddress();
        address.Street = "złotno";
        address.PostCode = "1234";
        address.City = "łodź";
        return address;
    }
    public OrderProduct AddProduct()
    {
        var order= new AllProduct();
        order.NameProduct = "Z całego świata";
        order.OrderDate= DateTime.Now;
        return order;
    }  

}
class AddUSA
{
    public Customer AddCust()
    {
        var customer = new USACustomer();
        customer.Name = "Adam";
        customer.Surname = "Kaźierczyk";
        customer.PhoneNumber = "1234567890";
        return customer;
    }
    public AdressCust AddAddress()
    {
        var address = new USAAddress();
        address.Street = "złotno";
        address.PostCode = "1234";
        address.City = "łodź";
        return address;
    }
    public OrderProduct AddProduct()
    {
        var order = new USAProduct();
        order.NameProduct = "Z całego świata";
        order.OrderDate = DateTime.Now;
        return order;
    }
    class AddGB
    {
        public Customer AddCust()
        {
            var customer = new GBCustomer();
            customer.Name = "Adam";
            customer.Surname = "Kaźierczyk";
            customer.PhoneNumber = "1234567890";
            return customer;
        }
        public AdressCust AddAddress()
        {
            var address = new GBAddress();
            address.Street = "złotno";
            address.PostCode = "1234";
            address.City = "łodź";
            return address;
        }
        public OrderProduct AddProduct()
        {
            var order = new GBProduct();
            order.NameProduct = "Z całego świata";
            order.OrderDate = DateTime.Now;
            return order;
        }

    }

}

public class Invoice
{
    private Customer _customer;
    private AdressCust _adresKlienta;
    private OrderProduct _zamowienie;

    public Invoice(Customer customer, AdressCust adresKlienta, OrderProduct zamowienie)
    {
        _customer = customer;
        _adresKlienta = adresKlienta;
        _zamowienie = zamowienie;   
    }
}

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {


            var calySwiat = new AddAll();
            var klienci = calySwiat.AddCust();
            var produkt = calySwiat.AddProduct();
            var adres = calySwiat.AddAddress();


            var zamowienie = new Invoice(klienci,adres,produkt);

            Console.ReadLine();
        }
    }

}



