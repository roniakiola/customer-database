using src.Database;

namespace src.Shared
{
  public class FileHelper
  {
    private const string FilePath = "customers.csv";

    public static void SaveData(Dictionary<int, Customer> customers)
    {
      using (StreamWriter writer = new StreamWriter(FilePath))
      {
        foreach (Customer customer in customers.Values)
        {
          writer.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Email}, {customer.Address}");
        }
      }
    }
    public static void LoadData(Dictionary<int, Customer> customers)
    {
      try
      {
        string[] data = File.ReadAllLines(FilePath);
        foreach (string customer in data)
        {
          string[] customerValues = customer.Split(",");
          Customer newCustomer = new Customer
          (
            customerValues[1].Trim(),
            customerValues[2].Trim(),
            customerValues[3].Trim(),
            customerValues[4].Trim()
          );
          newCustomer.Id = int.Parse(customerValues[0]);
          customers.Add(newCustomer.Id, newCustomer);
        }
      }
      catch (FileNotFoundException)
      {
        throw new ExceptionHandler("File not found");
      }
    }
  }
}