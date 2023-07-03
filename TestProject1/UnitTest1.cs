using Zoo.Class;
using Zoo.Interfaces;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("The elephant trumpets loudly.\r\nThe elephant sleeps standing up.", "Elephant")]
        [InlineData("The eagle screeches loudly.\r\nThe eagle sleeps on a high branch.", "eagle")]
        [InlineData("The lion roars loudly.\r\nThe lion sleeps in its den.", "lion")]
        [InlineData("The monkey chatters and screeches.\r\nThe monkey sleeps on a tree branch.", "monkey")]
        [InlineData("The panda makes a gentle grunting sound.\r\nThe panda sleeps in a tree or on the ground.", "panda")]
        [InlineData("The parrot imitates human speech.\r\nThe parrot sleeps on its perch.", "parrot")]
        [InlineData("The swan sings a graceful melody.\r\nThe swan sleeps on the water.", "swan")]
        [InlineData("The tiger growls fiercely.\r\nThe tiger sleeps in its lair.", "tiger")]
        public void Animal_SoundAndSleep_ShouldWriteCorrectMessagesToConsole(string expectedMessage, string name)
        {
            Animal animal;
            switch (name.ToLower())
            {
                case "elephant":
                    animal = new Elephant("Ello", 4);
                    break;
                case "eagle":
                    animal = new Eagle("Ella", 2);
                    break;
                case "lion":
                    animal = new Lion("Leo", 4);
                    break;
                case "monkey":
                    animal = new Monkey("Mike", 4);
                    break;
                case "panda":
                    animal = new Panda("Pan", 4);
                    break;
                case "parrot":
                    animal = new Parrot("Polly", 2);
                    break;
                case "swan":
                    animal = new Swan("Sara", 2);
                    break;
                case "tiger":
                    animal = new Tiger("Tom", 4);
                    break;
                default:
                    throw new ArgumentException("Invalid animal name.");
            }

            // Redirect console output
            using StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            animal.Sound();
            animal.Sleep();

            // Assert
            string actualMessage = consoleOutput.ToString().Trim();
            Assert.Equal(expectedMessage, actualMessage);
        }
        [Fact]
        public void TestInterfaceImplementation()
        {
            
            IBirds eagle = new Eagle("Eagle", 5);
            IMammals lion = new Lion("Lion", 8);

            Assert.True(eagle is IBirds);
            Assert.True(lion is IMammals);
        }

        [Fact]
        public void TestInheritance()
        {
            Eagle eagle = new Eagle("Eagle", 5);
            Lion lion = new Lion("Lion", 8);

            Assert.True(eagle is Fly);
            Assert.True(lion is EatMeat);
        }

        [Fact]
        public void TestPolymorphism()
        {
            Fly eagle = new Eagle("Eagle", 5);
            Fly parrot = new Parrot("Parrot", 3);

            eagle.Sleep(); // Outputs: "The eagle sleeps on its perch."
            parrot.Sleep(); // Outputs: "The parrot sleeps on its perch."

            Assert.True(eagle is Eagle);
            Assert.True(parrot is Parrot);
        }

        [Fact]
        public void TestMethodOverride()
        {
            Eagle eagle = new Eagle("Eagle", 5);
            Parrot parrot = new Parrot("Parrot", 3);

            eagle.Sound(); // Outputs: "The eagle screeches loudly."
            parrot.Sound(); // Outputs: "The parrot imitates human speech."

            Assert.True(eagle is Eagle);
            Assert.True(parrot is Parrot);
        }

        [Fact]
        public void TestConcreteAnimal()
        {
            Eagle eagle = new Eagle("Eagle", 5);
            Lion lion = new Lion("Lion", 8);

            Assert.True(eagle is Animal);
            Assert.True(lion is Animal);
        }

    }
}