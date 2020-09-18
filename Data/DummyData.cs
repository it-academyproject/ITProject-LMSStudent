using LMSStudent.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Adapted from https://github.com/medhatelmasry/HealthAPI/blob/master/HealthAPI/Data/DummyData.cs
namespace LMSStudent.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<LMSStudentContext>();
            context.Database.EnsureCreated();

            // Look for any users
            if (context.Users != null && context.Users.Any())
                return;

            var events = GetEvents().ToArray();
            context.Events.AddRange(events);
            context.SaveChanges();

            var itineraries = GetItineraries().ToArray();
            context.Itineraries.AddRange(itineraries);
            context.SaveChanges();

            var users = GetUsers().ToArray();
            context.Users.AddRange(users);
            context.SaveChanges();

            var attendees = GetAttendees().ToArray();
            context.Attendees.AddRange(attendees);
            context.SaveChanges();

            var topics = GetTopics().ToArray();
            context.Topics.AddRange(topics);
            context.SaveChanges();

            /*
            var resources = GetResources().ToArray();
            context.Resources.AddRange(resources);
            context.SaveChanges();

            var exercises = GetExercises().ToArray();
            context.Exercises.AddRange(exercises);
            context.SaveChanges();

            var teachingMaterials = GetTeachingMaterials().ToArray();
            context.TeachingMaterials.AddRange(teachingMaterials);
            context.SaveChanges();
            */
        }

        public static List<Event> GetEvents()
        {
            List<Event> events = new List<Event>() {
                new Event { 
                    Name="Student welcome", 
                    Description = "like each Monday, we welcome new students at IT Academy.", 
                    Date = new DateTime(2020, 7, 20, 9, 0, 0), 
                    Online = true, 
                    Type = "Special Event" 
                },
                new Event { 
                    Name="MySQL Masterclass", 
                    Description = "A masterclass on MySQL by the Common Block itinerary instructor.", 
                    Date = new DateTime(2020, 7, 23, 11, 30, 0), 
                    Online = false, Capacity = 25, 
                    Type = "Masterclass" 
                },
                new Event { 
                    Name="August holidays", 
                    Description = "IT Academy closes until 1 September. In the attached file you can find the calendar for September. Happy holidays!", 
                    Date = new DateTime(2020, 7, 30, 13, 0, 0), File = "calendar-september.xlsx", 
                    Online = false, 
                    Type = "Holidays" }
            };
            return events;
        }

        public static List<Itinerary> GetItineraries()
        {
            List<Itinerary> itineraries = new List<Itinerary>() {
                new Itinerary {
                    Name = ".Net",                    
                },
                new Itinerary {
                    Name = "Java",
                },
                new Itinerary {
                    Name = "FrontEnd React",
                },
                new Itinerary {
                    Name = "FrontEnd Angular",
                },
                new Itinerary {
                    Name = "FrontEnd",
                },
                new Itinerary {
                    Name = "Common Block",
                }
            };
            return itineraries;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>() {
                new User {
                    Name = "Rubén",
                    Surname = "Alcalde",
                    Email = "ra@example.com",
                    Type = "Admin",
                    ItineraryId = 2
                },
                new User {
                    Name = "Gerard",
                    Surname = "Ferrer",
                    Email = "gf@example.com",
                    Type = "Student",
                    ItineraryId = 3
                },
                new User {
                    Name = "Oriol",
                    Surname = "Muñiz",
                    Email = "om@example.com",
                    Type = "Student",
                    ItineraryId = 3
                },
                new User {
                    Name = "Francisco Javier",
                    Surname = "Rivas",
                    Email = "fjr@example.com",
                    Type = "Student",
                    ItineraryId = 6
                }
            };
            return users;
        }

        public static List<Attendee> GetAttendees()
        {
            List<Attendee> attendees = new List<Attendee>() {
                new Attendee {
                    IdEvent = 1,
                    IdStudent = 1
                },
                new Attendee {
                    IdEvent = 2,
                    IdStudent = 2,
                    Accepted = true
                },
                new Attendee {
                    IdEvent = 2,
                    IdStudent = 3,
                    Accepted = true
                }
            };
            return attendees;
        }

        public static List<Topic> GetTopics()
        {
            List<Topic> topics = new List<Topic>() {
                new Topic {Name = "C#"},
                new Topic {Name = "ASP.Net"},
                new Topic {Name = "Java"},
                new Topic {Name = "JavaScript"},
                new Topic {Name = "Angular"}
            };
            return topics;
        }

        /*
        public static List<Resource> GetResources()
        {
            List<Resource> resources = new List<Resource>() {
                new Resource {Name = "Exercise 3", Description = "Exercise 3 desc", File = "pdf", TopicId = 1 },
                new Resource {Name = "Exercise 2", Description = "Exercise 2 desc", File = "excel", TopicId = 2 },
                new Resource {Name = "Exercise 1", Description = "Exercise 1 desc", File = "word", TopicId = 2 },
                new Resource {Name = "TeachingMaterial 2", Description = "TeachingMaterial 2 desc", File = "excel", TopicId = 3 },
                new Resource {Name = "TeachingMaterial 1", Description = "TeachingMaterial 1 desc", File = "word", TopicId = 3 }
            };
            return resources;
        }

        public static List<Exercise> GetExercises()
        {
            List<Exercise> exercises = new List<Exercise>() {
                new Exercise {AvailableTime = 2, ResourceId = 5},
                new Exercise {AvailableTime = 2, ResourceId = 4},
                new Exercise {AvailableTime = 2, ResourceId = 3}
            };
            return exercises;
        }

        public static List<TeachingMaterial> GetTeachingMaterials()
        {
            List<TeachingMaterial> teachingMaterials = new List<TeachingMaterial>() {
                new TeachingMaterial {Type = "Word", Link = "www.itacademy.com", ResourceId = 2},
                new TeachingMaterial {Type = "Excel", Link = "www.itacademy2.com", ResourceId = 1}
            };
            return teachingMaterials;
        }
        */
    }
}
