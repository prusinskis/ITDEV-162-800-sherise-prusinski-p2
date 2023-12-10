using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second Post",
                        Body = "Mi bibendum neque egestas congue quisque egestas diam in. Consectetur libero id faucibus nisl tincidunt eget nullam non nisi. Faucibus turpis in eu mi bibendum. Eleifend mi in nulla posuere sollicitudin aliquam ultrices. Aenean sed adipiscing diam donec adipiscing. Neque egestas congue quisque egestas diam. Nec ultrices dui sapien eget mi proin sed libero. Gravida cum sociis natoque penatibus et magnis. Etiam tempor orci eu lobortis elementum nibh. Tincidunt lobortis feugiat vivamus at augue. Leo urna molestie at elementum eu. Tortor id aliquet lectus proin.",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third Post",
                        Body = "Ultricies mi eget mauris pharetra et ultrices. Proin sed libero enim sed. Malesuada fames ac turpis egestas sed. Scelerisque varius morbi enim nunc faucibus. Nec ultrices dui sapien eget mi. Egestas egestas fringilla phasellus faucibus scelerisque. Enim blandit volutpat maecenas volutpat blandit. Eros in cursus turpis massa tincidunt. Nibh praesent tristique magna sit amet purus gravida quis. Fames ac turpis egestas integer eget aliquet nibh praesent. Et malesuada fames ac turpis egestas sed. Leo duis ut diam quam nulla porttitor massa. Justo laoreet sit amet cursus sit amet. Faucibus in ornare quam viverra orci sagittis.",
                        Date = DateTime.Now.AddDays(-4)
                    }  
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}