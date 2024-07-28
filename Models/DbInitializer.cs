
using TodoApi.Data;

namespace TodoApi.Models
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();
            //
        }
    }
}
