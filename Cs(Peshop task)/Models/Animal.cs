namespace Cs_Peshop_task_.Models
{
    public abstract class Animal
    {
        public static int static_Id = 0;
        public int id { get; init; }
        private string _nickname;
        public string Nickname
        {
            get { return _nickname; }
            set
            {
                if (value != null)
                    _nickname = value;
                else
                    throw new Exception("Nickname is null");
            }
        }

        private double _age;
        public double age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                    _age = value;
                else throw new Exception("Age can not be negative number");
            }
        }

        public string Category { get; set; }


        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == null) throw new Exception("Gender is null");
                else
                {
                    if (value == "male" || value == "female" || value == "Male" || value == "Female")
                        _gender = value;
                    else
                        throw new Exception("Given gender is incorrect");
                }
            }
        }


        private int _energy;
        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value >= 0 && value <= 100)
                    _energy = value;
                else
                    throw new Exception("Energy can be min 0 and max 100");
            }
        }

        public ushort Price { get; set; }

        public ushort mealQuantity { get; set; }

        public Animal(string nickname, ushort age,string category ,string gender, ushort price)
        {
            this.id = ++static_Id;
            this.Nickname = nickname;
            this.age = age;
            this.Category = category;
            this.Energy = 100;
            this.Gender = gender;
            this.Price = price;
            this.mealQuantity = 0;
        }


        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Play();

        public override string ToString()
        {
            return $"Category: {Category} \nId: {id} \nNickname: {Nickname} \nAge: {age} \nGender: {Gender} \nEnergy: {Energy} \nPrice: {Price} \nMeal Quantity: {mealQuantity}\n";
        }


    }
}
