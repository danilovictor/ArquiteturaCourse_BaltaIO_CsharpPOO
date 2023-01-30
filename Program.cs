using ArqPayments.SubscripitionContext;
using System;
using System.Linq;
using ArqPayments.ContentContext;
using ArqPayments.SubscripitionContext;

namespace ArqPayments.ContentContext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article(" Artigo oop", "orientacao"));

            foreach (var items in articles)
            {
                Console.WriteLine(items.Id);
                Console.WriteLine(items.Title);
                Console.WriteLine(items.Url);

                var courses = new List<Course>();
                var courseOOP = new Course("Fundamentos OOP", "Fundamentos-oop");
                var courseCsharp = new Course("Fundamentos OOP", "Fundamentos-chsarp");
                var courseAspnet = new Course("Fundamentos OOP", "Fundamentos-aspnet");
                courses.Add(courseOOP);
                courses.Add(courseCsharp);
                courses.Add(courseAspnet);


                var careers = new List<Career>();
                var careerDotnet = new Career("Especialista .net", "especialista-dotnet");
                var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
                var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
                var careerItem3 = new CareerItem(3, "Aprenda .Net", "", courseAspnet);


                careerDotnet.Items.Add(careerItem);
                careers.Add(careerDotnet);

                foreach (var career in careers)
                {
                    Console.WriteLine(career.Title);
                    foreach (var item in career.Items.OrderBy(x => x.Order))
                    {
                        Console.WriteLine($"{item.Order} - {item.Title}");
                        Console.WriteLine(item.Course.Title);
                        Console.WriteLine(item.Course.Level);
                    }

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(payPalSubscription);
            }
        }
    }
}
}
