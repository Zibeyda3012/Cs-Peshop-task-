namespace Cs_Peshop_task_.Models
{
    public class Cat : Animal
    {
        public Cat(string nickname, ushort age, string category,string gender, ushort price) : base(nickname, age, category,gender, price)
        { }

        public override void Eat()
        {
            if (this.Energy <= 90)
            {
                Energy += 10;
                this.age += 0.4;
                this.Price += 3;
                this.mealQuantity += 1;
            }

            else if (this.Energy == 100)
                Console.WriteLine("I am full,I can't eat");

            else
            {
                Energy = 100;
                this.age += 0.4;
                this.Price += 3;
                this.mealQuantity += 1;
            }

        }

        public override void Sleep()
        {
            if (this.Energy <= 90)
                Energy += 10;

            else if (this.Energy == 100)
                Console.WriteLine("My energy is full,let's play:)");

            else
                this.Energy = 100;


        }

        public override void Play()
        {
            Console.WriteLine("Meow Meow,let's play");
            if (this.Energy >= 15)
                Energy -= 15;

            else if (this.Energy == 0)
                Console.WriteLine("I don't have energy to play");
            else
                Energy = 0;
        }

    }
}
