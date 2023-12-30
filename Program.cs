using Reviews;
using System.Text.Json;

var database = new Database();

//database.AddUser("bandernik", "Nikita");
//database.AddUser("ivanzolo2004", "Ivan");
//database.AddUser("emp1ree", "Oleg");


//database.SaveToFile();

database.LoadFromFile();

//database.AddFeedback(Guid.Parse("ce983f68-216b-4ba9-8c18-a68a7d18be4e"), "I love .net", 5);
//database.AddFeedback(Guid.Parse("ce983f68-216b-4ba9-8c18-a68a7d18be4e"), "qwerty", 2);
//database.AddFeedback(Guid.Parse("ce983f68-216b-4ba9-8c18-a68a7d18be4e"), "Hello world!", 3);

database.AddFeedback(Guid.Parse("e06a58fd-659b-4024-8e4e-3a3a06ffa554"), "Hello world!", 1);
database.AddFeedback(Guid.Parse("e06a58fd-659b-4024-8e4e-3a3a06ffa554"), "Hi world!", 2);
database.AddFeedback(Guid.Parse("e06a58fd-659b-4024-8e4e-3a3a06ffa554"), "aboba", 5);

//database.SaveToFile();

//database.LoadFromFile();

//database.DeleteUserById(Guid.Parse("e06a58fd-659b-4024-8e4e-3a3a06ffa554"));



//database.SaveToFile();


