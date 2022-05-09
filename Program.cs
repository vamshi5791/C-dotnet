using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnimalCLass
    {
    }

    class AnimalKingdom : Tiger, Lion, hynea, fox, elephant
    {

        public List<AnimalsActivity> tiger_details(List<AnimalsActivity> lists)
        {

            lists.Add(new AnimalsActivity { drinking = "tigers can drink water", eating = "tigers can eat Meet", running = "tigers can run Fastly" });

            return lists;

            //foreach (var animal in list)
            //{
            //    Console.WriteLine(animal.drinking +" ,"+animal.eating+","+animal.running );
            //}

        }
        public List<AnimalsActivity> lion_details(List<AnimalsActivity> lists)
        {
            lists.Add(new AnimalsActivity { drinking = "Lion can drink water", eating = "Lion can eat Meet", running = "Lion can run Fastly" });
            return lists;
        }
        public List<AnimalsActivity> hynea_details(List<AnimalsActivity> lists)
        {
            lists.Add(new AnimalsActivity { drinking = "Hyna can drink water", eating = "Hyna can eat Meet", running = "Hyna can run Fastly" });
            return lists;

        }
        public List<AnimalsActivity> fox_details(List<AnimalsActivity> lists)
        {
            lists.Add(new AnimalsActivity { drinking = "Fox can drink water", eating = "Fox can eat Meet", running = "Fox can run Fastly" });
            return lists;
        }
        public List<AnimalsActivity> elephant_details(List<AnimalsActivity> lists)
        {
            lists.Add(new AnimalsActivity { drinking = "Elephant can drink water", eating = "Elephant can eat Grass", running = "Elephant can run Slowly" });
            return lists;
        }



        static void Main()
        {
            AnimalKingdom ak = new AnimalKingdom();

            List<AnimalsActivity> list = new List<AnimalsActivity>();

            ak.tiger_details(list);

            ak.fox_details(list);
            ak.lion_details(list);
            ak.hynea_details(list);
            ak.elephant_details(list);
            foreach (var animal in list)
            {
                Console.WriteLine(animal.drinking + " ," + animal.eating + "," + animal.running);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    interface Tiger
    {
        List<AnimalsActivity> tiger_details(List<AnimalsActivity> obj);
    }
    interface Lion
    {
        List<AnimalsActivity> lion_details(List<AnimalsActivity> obj);
    }
    interface hynea
    {
        List<AnimalsActivity> hynea_details(List<AnimalsActivity> obj);
    }
    interface fox
    {
        List<AnimalsActivity> fox_details(List<AnimalsActivity> obj);
    }
    interface elephant
    {
        List<AnimalsActivity> elephant_details(List<AnimalsActivity> obj);
    }
    public class AnimalsActivity
    {
        public string eating { get; set; }
        public String running { get; set; }
        public string drinking { get; set; }
    }



}