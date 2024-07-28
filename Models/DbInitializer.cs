
using TodoApi.Data;

namespace TodoApi.Models
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            //look for any tables
            if (context.TodoItems.Any())
            {
                return;
            }

            //look for database with some test data
            var todo = new TodoItem[]
            {
                new TodoItem {Name = "Learn C#"},
                new TodoItem {Name = "Learn ASP.NET Core"},
                new TodoItem {Name = "Build a web app"}
            };

            foreach (var item in todo)
            {
                context.TodoItems.Add(item);
            }

            context.SaveChanges();
        }
    }
}
