using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    internal class Controller
    {
        public void Save(Goods[] goods)
        {

            var json = JsonSerializer.Serialize<Goods[]>(goods);
            File.WriteAllText("goods.json", json);

        }
        public Goods[] Load(string path)
        {
            path = "goods.json";
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(path);
                Goods[] goods = JsonSerializer.Deserialize<Goods[]>(json);
                return goods;
            }

        }
    }
}