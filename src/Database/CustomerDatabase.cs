namespace src.Database
{
  public class CustomerDatabase
  {
    public Dictionary<int, Customer> customers;

    public CustomerDatabase()
    {
      customers = new Dictionary<int, Customer>();
    }

    public bool AddCustomer(Customer newCustomer)
    {
      if (customers.Values.Any(customer => customer.Email == newCustomer.Email))
      {
        return false;
      }
      newCustomer.Id = GenerateId();
      customers.Add(newCustomer.Id, newCustomer);
      return true;
    }

    public void ReadCustomers()
    {
      foreach (Customer customer in customers.Values)
      {
        Console.WriteLine($"ID: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}, Address: {customer.Address}");
      }
    }

    public void UpdateCustomer(Customer customer, Customer updatedCustomer)
    {
      Customer oldCustomer = FindCustomerById(customer.Id);
      if (oldCustomer == null)
      {
        Console.WriteLine("Customer not found");
        return;
      }
      if (customers.Values.Any(c => c.Email == updatedCustomer.Email && c.Id != updatedCustomer.Id))
      {
        Console.WriteLine("Email address taken");
        return;
      }
      oldCustomer.FirstName = updatedCustomer.FirstName;
      oldCustomer.LastName = updatedCustomer.LastName;
      oldCustomer.Email = updatedCustomer.Email;
      oldCustomer.Address = updatedCustomer.Address;
    }

    public Customer FindCustomerById(int id)
    {
      if (customers.ContainsKey(id))
      {
        return customers[id];
      }
      return null;
    }

    public int GenerateId()
    {
      if (customers.Count > 0)
      {
        return customers.Keys.Max() + 1;
      }
      else
      {
        return 0;
      }
    }
  }
}