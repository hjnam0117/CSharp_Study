using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp10
{
    abstract class Juice
    {
        public int Level { get; set; }
        public abstract string Drink();
    }
    class Ade : Juice
    {
        public override string Drink()
        {
            return "마시다";
        }
    }
    class Lemonade : Ade 
    { 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lemonade j = new Lemonade();
            Console.WriteLine(j.Drink());
        }
    }
}
