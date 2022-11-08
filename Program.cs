using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {

            Goods good1 = new Goods();
            Goods good2 = new Goods();
            Goods good3 = new Goods();
            Goods good4 = new Goods();
            Goods good5 = new Goods();
            Goods good6 = new Goods();
            Goods good7 = new Goods();
            Goods good8 = new Goods();
            Goods good9 = new Goods();
            Goods good10 = new Goods();

            string[] Name = new string[10] { "Кровать", "Стол", "Стул", "Мышка", "Клавиатура", "Футболка", "Кофта", "Ботинки", "Шкаф", "Тумбочка" };
            int[] Cost = new int[10] { 15000, 7000, 5000, 2000, 7000, 1500, 2500, 2000, 10000, 6000 };
            string[] Category = new string[10] { "Мебель", "Мебель", "Мебель", "Периферия", "Периферия", "Одежда", "Одежда", "Обувь", "Мебель", "Мебель" };

            Goods[] goods = new Goods[10] { good1, good2, good3, good4, good5, good6, good7, good8, good9, good10 };

            for (int i = 0; i < goods.Length; i++) { 
            goods[i].name = Name[i];
            goods[i].cost = Cost[i];
            goods[i].category = Category[i];

            }


            Controller controller = new Controller();

            controller.Save(goods);
            string path = "goods.json";


            var t = controller.Load(path);
            foreach (var item in t)
            {
                Console.WriteLine("{0} {1} {2} ", item.name, item.cost, item.category);
            }

        }
    }
}