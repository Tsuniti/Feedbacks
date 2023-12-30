using Reviews;
using System.Text.Json;

var database = new Database();

//database.AddUser("bandernik", "Nikita");
//database.AddUser("ivanzolo2004", "Ivan");
//database.AddUser("emp1ree", "Oleg");


//database.SaveToFile();

database.LoadFromFile();

<<<<<<< HEAD
//database.AddFeedback(Guid.Parse("2d0d0352-49f6-412c-952d-74853f50b1a9"), "I love .net", 5);
//database.AddFeedback(Guid.Parse("2d0d0352-49f6-412c-952d-74853f50b1a9"), "qwerty", 2);
//database.AddFeedback(Guid.Parse("0d1b3a81-7586-457e-82db-a660d039ed6c"), "Hello world!", 3);

//database.AddFeedback(Guid.Parse("d3a75566-4fe1-4124-a0bc-5e4130299f10"), "Hello world!", 1);
//database.AddFeedback(Guid.Parse("d3a75566-4fe1-4124-a0bc-5e4130299f10"), "Hi world!", 3);
//database.AddFeedback(Guid.Parse("0d1b3a81-7586-457e-82db-a660d039ed6c"), "aboba", 5);
=======
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
>>>>>>> deletingUserByID

//database.SaveToFile();
double avarage = database.FeedbacksAvarageRating();
Console.WriteLine($"Avarage rating of feedbacks: {avarage}");

