
using CoursePlataform.ContentContext;
using CoursePlataform.ContentContext.Enums;

namespace CoursePlataform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Aprendendo C#", "aprendendo-csharp"));
            articles.Add(new Article("Aprendendo .NET", "aprendendo-dotnet"));
            articles.Add(new Article("Aprendendo ASP.NET Core", "aprendendo-aspnetcore"));
            articles.Add(new Article("Aprendendo Entity Framework Core", "aprendendo-efcore"));
            articles.Add(new Article("Aprendendo SQL Server", "aprendendo-sqlserver"));
            articles.Add(new Article("Aprendendo MongoDB", "aprendendo-mongodb"));
            articles.Add(new Article("Aprendendo Redis", "aprendendo-redis"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine(article.CreatedAt);
                Console.WriteLine("------------------------------\n");
            }
            
            var courseCsharp = new Course(ELevel.Iniciante, "Aprendendo C#", "aprendendo-csharp", new Category(1, "Programação"));
            var courseOOP = new Course(ELevel.Intermediario, "Aprendendo Orientação a Objetos", "aprendendo-oop", new Category(1, "Programação"));
            var courseDotnet = new Course(ELevel.Iniciante, "Aprendendo .NET", "aprendendo-dotnet", new Category(1, "Programação"));
            var courseAspnet = new Course(ELevel.Iniciante, "Aprendendo ASP.NET Core", "aprendendo-aspnetcore", new Category(1, "Programação"));
            
            var courses = new List<Course>();
            courses.Add(courseCsharp);
            courses.Add(courseOOP);
            courses.Add(courseDotnet);
            courses.Add(courseAspnet);
            
            

            foreach (var course in courses)
            {
                Console.WriteLine(course.Id);
                Console.WriteLine(course.Title);
                Console.WriteLine(course.Url);
                Console.WriteLine(course.CreatedAt);
                Console.WriteLine($"Nível: {course.Level}");
                Console.WriteLine($"Categoria: {course.Category.Name}");
                Console.WriteLine("------------------------------\n");
            }
            var careers = new List<Career>();
            var careerDotnet = new Career("Carreira .NET", "carreira-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "", courseDotnet);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "", courseOOP);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Id);
                Console.WriteLine(career.Title);
                Console.WriteLine(career.Url);
                Console.WriteLine(career.CreatedAt);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"Item: {item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Url);
                    Console.WriteLine(item.Course.Level);
                    Console.WriteLine("------------------------------\n");
                    
                }
            }


        }
    }
}