using Reviews;
using System.Text.Json;

var database = new Database();

//database.AddUser("bandernik", "Nikita");
//database.AddUser("ivanzolo2004", "Ivan");
//database.AddUser("emp1ree", "Oleg");


//database.SaveToFile();

database.LoadFromFile();

//database.AddFeedback(Guid.Parse("2d0d0352-49f6-412c-952d-74853f50b1a9"), "I love .net", 5);
//database.AddFeedback(Guid.Parse("2d0d0352-49f6-412c-952d-74853f50b1a9"), "qwerty", 2);
//database.AddFeedback(Guid.Parse("0d1b3a81-7586-457e-82db-a660d039ed6c"), "Hello world!", 3);

//database.AddFeedback(Guid.Parse("d3a75566-4fe1-4124-a0bc-5e4130299f10"), "Hello world!", 1);
//database.AddFeedback(Guid.Parse("d3a75566-4fe1-4124-a0bc-5e4130299f10"), "Hi world!", 3);
//database.AddFeedback(Guid.Parse("0d1b3a81-7586-457e-82db-a660d039ed6c"), "aboba", 5);

//database.SaveToFile();
double avarage = database.FeedbacksAvarageRating();
Console.WriteLine($"Avarage rating of feedbacks: {avarage}");

