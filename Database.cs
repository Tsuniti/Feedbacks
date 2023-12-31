﻿using Reviews.Entityes;
using Reviews.Interfaces;
using System.Text.Json;

namespace Reviews;

public class Database : IPersistable
{
    //1. хранить коллекции пользователей и отзывов
    //2. сохранять файл
    private List<User> _users;
    private List<Feedback> _feedbacks;
    private const string _usersFilename = "users.json";
    private const string _feedbacksFilename = "feedbacks.json";


    public Database()
    {
        _users = new List<User>();
        _feedbacks = new List<Feedback>();
    }

    public void AddUser(string username, string? realname = null)
    {
        if (_users.Any(user => user.UserName.Equals(username)))
            throw new ArgumentException("Username already exists", nameof(username));
        _users.Add(new User
        {
            UserName = username,
            RealName = realname
        });
    }

    public void DeleteUserById(Guid userId)
    {

        if (!_users.Any(user => user.Id == userId))
            throw new ArgumentException("User not exists", nameof(userId));

        foreach (var user in _users)
        {
            if (user.Id == userId)
            {
                // while feedbacks contains feedback from the user
                while (_feedbacks.Any(feedback => feedback.UserId == userId))
                {
                    // delete the first feedback found from the user and repeat the cycle
                    _feedbacks.Remove(_feedbacks.First(feedback => feedback.UserId == userId));
                }

                _users.Remove(user); // now deleting user

                return; // for does not need to continue, so we can retern

            }
        }
    }
    public void AddFeedback(Guid userId, string text, uint rating)
    {
        if (!_users.Any(user => user.Id == userId))
            throw new ArgumentException("User not exists", nameof(userId));

        if (rating > 5)
        {
            throw new ArgumentException("Rating out of range", nameof(rating));
        }
        _feedbacks.Add(new Feedback
        {
            UserId = userId,
            Text = text,
            Rating = rating
        });
    }

    public void PrintAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine(user);
        }
    }

    public void SaveToFile()
    {
        // open file users, json, write
        using (var writer = new StreamWriter(_usersFilename))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string usersJson = JsonSerializer.Serialize(_users, options);
            writer.Write(usersJson);
        }
        using (var writer = new StreamWriter(_feedbacksFilename))
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string feedbacksJson = JsonSerializer.Serialize(_feedbacks, options);
            writer.Write(feedbacksJson);
        }
    }

    public void LoadFromFile()
    {
        using (var reader = new StreamReader(_usersFilename))
        {
            // read json
            string usersJson = reader.ReadToEnd();
            // json to users list
            _users = JsonSerializer.Deserialize<List<User>>(usersJson);
        }
        using (var reader = new StreamReader(_feedbacksFilename))
        {
            string feedbacksJson = reader.ReadToEnd();
            _feedbacks = JsonSerializer.Deserialize<List<Feedback>>(feedbacksJson);
        }
    }
    public IEnumerable<Feedback> GetFeedbacksByUsername(string username)
    {
        var user = _users.FirstOrDefault(user => user.UserName.Equals(username));
        if (user == null)
            throw new ArgumentException("User not found", nameof(username));

        return _feedbacks.Where(fb => fb.UserId.Equals(user.Id));
    }
    //<<<<<<< HEAD
    public User GetUserByFeedbackId(Guid feedbackId)
    {
        // Find a review with the given identifier in the collection of reviews
        var feedback = _feedbacks.FirstOrDefault(fb => fb.Id.Equals(feedbackId));
        // Check if the review was found
        if (feedback == null)
            throw new ArgumentException("Feedback not found", nameof(feedbackId));
        // Find the user by the user ID associated with the found review
        var user = _users.FirstOrDefault(user => user.Id.Equals(feedback.UserId));

        // Check if the user is found
        if (user == null)
            throw new ArgumentException("User not found for the given feedback", nameof(feedbackId));

        //<<<<<<< HEAD

        //=======
        // Возвращаем найденного пользователя
        //>>>>>>> findUser
        return user;
    }

        //=======
        public double FeedbacksAvarageRating()
        {
            uint ratingSum = 0;
            uint feedbacksAmount = 0;
            foreach (Feedback feedback in _feedbacks)
            {
                ratingSum += feedback.Rating;
                feedbacksAmount += 1;
            }
            return ratingSum / feedbacksAmount;
            //>>>>>>> origin/main
        }
    }
