namespace src.Database
{
  public class Customer
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Customer(string firstName, string lastName, string email, string address)
    {
      FirstName = firstName;
      LastName = lastName;
      Email = email;
      Address = address;
    }
  }
}