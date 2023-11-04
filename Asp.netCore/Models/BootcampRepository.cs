
namespace Asp.netCore.Models
{
    public class BootcampRepository
    {
        private static List<Bootcamp> bootcamps;

        public static void SetBootcamps()
        {
            //Currently behaves like database
             bootcamps = new List<Bootcamp>
            {
                new Bootcamp() { Id = 1, Name = "Test1", Desc = "Testing1" },
                new Bootcamp() { Id = 2, Name = "Test2", Desc = "Testing2" },
                new Bootcamp() { Id = 3, Name = "Test3", Desc = "Testing3" },
                new Bootcamp() { Id = 4, Name = "Test4", Desc = "Testing4" },
                new Bootcamp() { Id = 5, Name = "Test5", Desc = "Testing5" }
            };
        }

        public static List<Bootcamp> GetBootcamps()
        {
            return bootcamps;
        }

        public static Bootcamp? GetCourseById(int id)
        {
            return bootcamps.FirstOrDefault(c => c.Id == id);
        }
    }
}