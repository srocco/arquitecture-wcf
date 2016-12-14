using PoC.Agents;
using PoC.Entities.Criteria;

namespace PoC.Console {
    class Program {
        static void Main(string[] args) {
            ProductCriteria productCriteria = new ProductCriteria();
            var items = ProductAgent.Instance().GeyByCriteria(productCriteria);
            
            foreach (var item in items) {
                System.Console.WriteLine(item.Name);
            }

            System.Console.ReadLine();
        }
    }
}
