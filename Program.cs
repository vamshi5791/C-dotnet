using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class FamilyTree
    {
        static void Main()
        {
            FamilyTree tree = new FamilyTree();
            tree.PrintFamilyTotaldetails("Vamshi");
           
            Console.ReadLine();
        }
        public void PrintFamilyTotaldetails(string name)
        {
            Child objchild = new Child();
            objchild.ChildName1 = name;
            Familydetails(objchild);
            Console.WriteLine("================relationships of family=====================");
            printRelation(objchild);
        }
        public void Familydetails(Child obj)
        {
            string result = $"Surname :{obj.Surname} \n GrandFather :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
            + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n Child :{obj.ChildName1} \n"
            + $"Location :{obj.Location} , City :{obj.City}";
            Console.WriteLine(result);
        }
        public void printRelation(Child obj)
        {
            Console.WriteLine(obj.GrandParentName1 + " is the father of:" + obj.ParentName1);
            Console.WriteLine(obj.GrandParentName1 + " is the husband of of:" + obj.GrandParentName2);
            Console.WriteLine(obj.ParentName1 + " is the son of of:" + obj.ChildName1);
            Console.WriteLine(obj.ParentName2 + " is the mother of of:" + obj.ChildName1);



        }
    }
    public class GrandParent
    {
        public string GrandParentName1 { get; set; } = "Rajesham" ;
        public string GrandParentName2 { get; set; } = "Laxminarsavva";
        public string Location { get; set; } = "sircilla local";
        public string Surname { get; set; } = "Govindhu";
        public string City { get; set; } = "Rajanna sircilla";
    }
   
         public class Parent : GrandParent
    {
        public string ParentName1 { get; set; } = "Satyanarayana";
        public string ParentName2 { get; set; } = "Mamatha";
    }

      
    
    public class Child : Parent
    {
        public string ChildName1 { get; set; }
    }
}

