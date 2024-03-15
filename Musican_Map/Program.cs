using Musican_Map.Context;
using Musican_Map.Entites;

namespace Musican_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MusicandbContext MusicandbContext = new MusicandbContext())
            {

                Musican musican = new Musican
                {

                    Name = "Mohamed Elnahas",

                    PhoneNumber = 01016928780,

                    City = "Cairo",

                    Street = "elshorouk",



                };
                  
                MusicandbContext.musicans.Add(musican);
                Console.WriteLine(MusicandbContext.Entry(musican).State);

                MusicandbContext.SaveChanges();

                Album album = new Album
                {

                    //our daata

                };

                //all classes like that 

            }

        }
    } }
