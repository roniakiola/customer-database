using src.Database;

CustomerDatabase db = new CustomerDatabase();

Customer customer1 = new Customer("John", "Does", "john.does@mail.com", "Lorem Street 11");
Customer customer2 = new Customer("Lisa", "Nodoes", "lisa.nodoes@mail.com", "Bulevard 65");

Customer updatedJohn = new Customer("John", "Updated", "john.does@mail.com", "Ipsum Street 2");
Customer updatedLisa = new Customer("Lisa", "Nodoes", "lisa.nodoes@newmail.com", "NewAddress 3");

Customer falsyUpdate = new Customer("John", "Does", "lisa.nodoes@newmail.com", "Lorem Street 11");

db.AddCustomer(customer1);
db.AddCustomer(customer2);
db.ReadCustomers();
db.UpdateCustomer(customer1, updatedJohn);
db.UpdateCustomer(customer2, updatedLisa);
db.UpdateCustomer(customer1, falsyUpdate);
db.ReadCustomers();