using Reviews;
using System.Text.Json;

var database = new Database();

//database.AddUser("bandernik", "Nikita");
//database.AddUser("ivanzolo2004", "Ivan");
//database.AddUser("emp1ree", "Oleg");


//database.SaveToFile();

database.LoadFromFile();

//database.AddFeedback(Guid.Parse("0fae914e-70db-4da0-94dd-ef1fa44402cc"), "I love .net", 5);
//database.AddFeedback(Guid.Parse("0fae914e-70db-4da0-94dd-ef1fa44402cc"), "qwerty", 2);
//database.AddFeedback(Guid.Parse("0fae914e-70db-4da0-94dd-ef1fa44402cc"), "Hello world!", 3);

//database.AddFeedback(Guid.Parse("9561ea7a-6117-4b9c-add1-8c8f8cc189ad"), "Hello world!", 1);
//database.AddFeedback(Guid.Parse("9561ea7a-6117-4b9c-add1-8c8f8cc189ad"), "Hi world!", 2);
//database.AddFeedback(Guid.Parse("9561ea7a-6117-4b9c-add1-8c8f8cc189ad"), "aboba", 5);

database.SaveToFile();


