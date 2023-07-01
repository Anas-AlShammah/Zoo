using Zoo.Class;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Elephant("Ello", 4);
            var animal2 = new Lion("Simba", 5);
            var animal3 = new Monkey("Momo", 3);
            var animal4 = new Panda("Kai", 2);
            var animal5 = new Swan("Lily", 1);
            var animal6 = new Eagle("Aquila", 6);
            var animal7 = new Parrot("Charlie", 4);
            animal1.Sleep();
            animal1.Sound();
            animal2.Sleep();
            animal2.Sound();
            animal3.Sleep();
            animal3.Sound();
            animal4.Sleep();
            animal4.Sound();
            animal5.Sleep();
            animal5.Sound();
            animal6.Sleep();
            animal6.Sound();
            animal7.Sleep();
            animal7.Sound();
         


        }
    }
}