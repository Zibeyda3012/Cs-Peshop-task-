
using System.Collections.Generic;

namespace Cs_Peshop_task_.Models
{

    enum AnimalCategory
    {
        Cat,
        Dog,
        Fish,
        Bird
    }

    public class PetShop
    {
        public int budget { get; set; }
        public int cat_food { get; set; }
        public int dog_food { get; set; }
        public int fish_food { get; set; }
        public int bird_food { get; set; }




        IDictionary<string, int> FoodDepo = new Dictionary<string, int>();
        List<Cat> Cats = new List<Cat>()
        {
            new Cat("Milky",2,"Cat","Female",200),
            new Cat("Kuro",3,"Cat","Male",200)
        };

        List<Dog> Dogs = new List<Dog>()
        {
            new Dog("Toplan",5,"Dog","Male",500),
            new Dog("Alabash",3,"Dog","Male",700)
        };

        List<Bird> Birds = new List<Bird>();
        List<Fish> Fish = new List<Fish>();


        public PetShop()
        {
            FoodDepo.Add("Cat Food", 3);
            FoodDepo.Add("Dog Food", 5);
            FoodDepo.Add("Bird Food", 2);
            FoodDepo.Add("Fish Food", 4);
            budget = 200;
            cat_food = 2;
            dog_food = 2;
            fish_food = 2;
            bird_food = 2;

        }

        public void Visual()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" ____   ___ ______  _____ __ __   ___   ____        ____   ____  ___ ___    ___ 
|    \ /  _]      |/ ___/|  |  | /   \ |    \      /    | /    ||   |   |  /  _]
|  o  )  [_|      (   \_ |  |  ||     ||  o  )    |   __||  o  || _   _ | /  [_ 
|   _/    _]_|  |_|\__  ||  _  ||  O  ||   _/     |  |  ||     ||  \_/  ||    _]
|  | |   [_  |  |  /  \ ||  |  ||     ||  |       |  |_ ||  _  ||   |   ||   [_ 
|  | |     | |  |  \    ||  |  ||     ||  |       |     ||  |  ||   |   ||     |
|__| |_____| |__|   \___||__|__| \___/ |__|       |___,_||__|__||___|___||_____|
                                                                                ");

            Console.ForegroundColor= ConsoleColor.White;
        }


        public void printMenu(int select)
        {
            string[] arr = new string[] { "New Game", "Exit" };

            Visual();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == select - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\t=> " + arr[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.WriteLine("\t\t\t\t" + arr[i]);

            }
        }

        public void MainMenu()
        {
            int select = 1;

            do
            {
                Console.Clear();
                printMenu(select);

                ConsoleKeyInfo info = Console.ReadKey(true);

                if (info.Key == ConsoleKey.DownArrow)
                {
                    if (select == 2) select = 1;
                    else
                        select++;
                }

                else if (info.Key == ConsoleKey.UpArrow)
                {
                    if (select == 1) select = 2;
                    else
                        select--;
                }

                else if (info.Key == ConsoleKey.Enter)
                {
                    if (select == 1) //new game
                    {
                        Console.Clear();
                        NewGameMenu();
                    }

                    else if (select == 2)  //exit
                    {
                        Console.Clear();
                        Console.WriteLine("You are quitting game...");
                        Thread.Sleep(500);
                        break;
                    }
                }



            } while (true);
        }

        public void printNewGameMenu(int select)
        {
            string[] arr = new string[] { "Show All Pets", "Show Pet by Id", "Feed Pet by Id", "Play with Pet", "Have Pet Sleep by Id", "Add New Pet", "Sell Pet", "Buy Food", "Show Budget", "Show Food Storage", "Show Total Consumed Meal Quantity", "Show Total price", "Exit" };

            Visual();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == select - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t"+arr[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.WriteLine("\t\t\t\t" +arr[i]);
            }
        }

        public void NewGameMenu()
        {
            int select = 1;

            do
            {
                Console.Clear();
                printNewGameMenu(select);

                ConsoleKeyInfo info = Console.ReadKey(true);

                if (info.Key == ConsoleKey.DownArrow)
                {
                    if (select == 13) select = 1;
                    else
                        select++;
                }

                else if (info.Key == ConsoleKey.UpArrow)
                {
                    if (select == 1) select = 13;
                    else
                        select--;
                }

                else if (info.Key == ConsoleKey.Enter)
                {
                    if (select == 1) //Show All Pets
                    {
                        Console.Clear();
                        ShowAllAnimals();
                    }

                    else if (select == 2) //Show Pet by Id
                    {
                        Console.Clear();

                        int id;
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        ShowPetById(id);
                    }

                    else if (select == 3) //Feed Pet by Id
                    {
                        Console.Clear();

                        int id;
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        FeedPetById(id);
                    }

                    else if (select == 4) //Play with pet
                    {
                        Console.Clear();

                        int id;
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        PlayWithPet(id);

                    }

                    else if (select == 5)  //Have animal sleep by Id
                    {
                        int id;
                        Console.Clear();
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        HavePetSleepById(id);
                    }

                    else if (select == 6) //Add New Pet
                    {
                        Console.Clear();
                        addNewPet();
                    }

                    else if (select == 7) //Sell Pet
                    {
                        int id;
                        Console.Clear();
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        SellPet(id);

                    }

                    else if (select == 8) //Buy Food
                    {
                        Console.Clear();
                        BuyFood();
                    }

                    else if (select == 9) //Show Account
                    {
                        Console.Clear();
                        Console.WriteLine("Total budget: " + budget);
                    }

                    else if (select == 10) //Show Food Storage
                    {
                        Console.Clear();
                        Console.WriteLine($"Cat Food: {cat_food} \nDog Food: {dog_food} \nFish Food: {fish_food} \nBird Food: {bird_food}");
                    }

                    else if (select == 11) //meal quantity
                    {
                        Console.Clear();
                        calculateTotalMealQuantity();
                    }

                    else if (select == 12) //Show Total price
                    {
                        Console.Clear();
                        calculateTotalPriceofpets();
                    }

                    else if (select == 13) //exit
                    {
                        Console.Clear();
                        return;
                    }

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPlease enter backspace button to back to main menu...");
                    Console.ForegroundColor = ConsoleColor.White;
                    while (info.Key != ConsoleKey.Backspace)
                    {
                        info = Console.ReadKey(true);
                        if (info.Key == ConsoleKey.Backspace)
                        {
                            Console.Clear();
                            break;
                        }

                    } 
                }


            } while (true);
        }

        public bool CheckId(int id)
        {
            foreach (var item in Cats)
            {
                if (item.id == id) return true;
            }

            foreach (var item in Dogs)
            {
                if (item.id == id) return true;
            }

            foreach (var item in Fish)
            {
                if (item.id == id) return true;
            }

            foreach (var item in Birds)
            {
                if (item.id == id) return true;
            }

            return false;
        }

        public string CheckCategory(int id)
        {
            foreach (var item in Cats)
            {
                if (item.id == id)
                    return item.Category;
            }

            foreach (var item in Dogs)
            {
                if (item.id == id)
                    return item.Category;
            }

            foreach (var item in Fish)
            {
                if (item.id == id)
                    return item.Category;
            }

            foreach (var item in Birds)
            {
                if (item.id == id)
                    return item.Category;
            }

            return " ";


        }


        public void ShowPetById(int id)
        {
            bool checkIfFound = false;
            foreach (var item in Cats)
            {
                if (item.id == id)
                {
                    Console.WriteLine(item.ToString());
                    checkIfFound = true;
                    break;
                }
            }

            if (checkIfFound) return;
            else
            {
                foreach (var item in Dogs)
                {
                    if (item.id == id)
                    {
                        Console.WriteLine(item.ToString());
                        checkIfFound = true;
                        break;
                    }
                }

                if (checkIfFound) return;
                else
                {
                    foreach (var item in Fish)
                    {
                        if (item.id == id)
                        {
                            Console.WriteLine(item.ToString());
                            checkIfFound = true;
                            break;
                        }
                    }

                    if (checkIfFound) return;
                    else
                    {
                        foreach (var item in Birds)
                        {
                            if (item.id == id)
                            {
                                Console.WriteLine(item.ToString());
                                checkIfFound = true;
                                return;
                            }
                        }

                        if (!checkIfFound)
                        {
                            Console.WriteLine("Pet with this Id is not found");
                            return;
                        }
                    }
                }

            }

        }

        public void ShowAllAnimals()
        {
            foreach (var item in Cats)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            foreach (var item in Dogs)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            foreach (var item in Fish)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            foreach (var item in Birds)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public void FeedPetById(int id)
        {
            if (CheckId(id))
            {
                string category = CheckCategory(id);

                switch (category)
                {
                    case "Cat":
                        if (cat_food > 0)
                        {
                            foreach (var item in Cats)
                            {
                                if (item.id == id)
                                {
                                    item.Eat();
                                    cat_food--;
                                }
                            }
                        }
                        else
                            Console.WriteLine("there is no food left in depo");

                        break;

                    case "Dog":
                        if (dog_food > 0)
                        {
                            foreach (var item in Dogs)
                                if (item.id == id)
                                {
                                    item.Eat();
                                    dog_food--;
                                }
                        }

                        else
                            Console.WriteLine("there is no food left in depo");
                        break;

                    case "Fish":
                        if (fish_food > 0)
                        {
                            foreach (var item in Fish)
                                if (item.id == id)
                                {
                                    item.Eat();
                                    fish_food--;
                                }
                        }

                        else
                            Console.WriteLine("there is no food left in depo");
                        break;

                    case "Bird":
                        if (bird_food > 0)
                        {
                            foreach (var item in Birds)
                                if (item.id == id)
                                {
                                    item.Eat();
                                    bird_food--;
                                }
                        }

                        else
                            Console.WriteLine("there is no food left in depo");
                        break;


                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Pet with this id is not found!!!");
                return;
            }
        }

        public void PlayWithPet(int id)
        {
            if (CheckId(id))
            {
                string category = CheckCategory(id);

                switch (category)
                {
                    case "Cat":
                        foreach (var item in Cats)
                            if (item.id == id)
                                item.Play();

                        break;

                    case "Dog":
                        foreach (var item in Dogs)
                            if (item.id == id)
                                item.Play();

                        break;

                    case "Fish":
                        foreach (var item in Fish)
                            if (item.id == id)
                                item.Play();

                        break;

                    case "Bird":
                        foreach (var item in Birds)
                            if (item.id == id)
                                item.Play();

                        break;


                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Pet with this id is not found!!!");
                return;
            }
        }

        public void HavePetSleepById(int id)
        {
            if (CheckId(id))
            {
                string category = CheckCategory(id);

                switch (category)
                {
                    case "Cat":
                        foreach (var item in Cats)
                            if (item.id == id)
                                item.Sleep();

                        break;

                    case "Dog":
                        foreach (var item in Dogs)
                            if (item.id == id)
                                item.Sleep();

                        break;

                    case "Fish":
                        foreach (var item in Fish)
                            if (item.id == id)
                                item.Sleep();

                        break;

                    case "Bird":
                        foreach (var item in Birds)
                            if (item.id == id)
                                item.Sleep();

                        break;


                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Pet with this id is not found!!!");
                return;
            }
        }

        public void addNewPet()
        {
            string nickname, category, gender;
            ushort age, price;

            Console.Write("Enter category(cat/dog/fish/bird): ");
            category = Console.ReadLine();

            Console.Write("Enter Nickname: ");
            nickname = Console.ReadLine();

            Console.Write("Enter gender: ");
            gender = Console.ReadLine();

            Console.Write("Enter age: ");
            age = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Enter price: ");
            price = Convert.ToUInt16(Console.ReadLine());

            if (category == "cat" || category == "Cat")
            {
                category = (AnimalCategory.Cat).ToString();

                Cat newcat = new Cat(nickname, age, category, gender, price);
                Cats.Add(newcat);

            }

            else if (category == "dog" || category == "Dog")
            {
                category = (AnimalCategory.Dog).ToString();

                Dog dog = new Dog(nickname, age, category, gender, price);
                Dogs.Add(dog);
            }

            else if (category == "fish" || category == "Fish")
            {
                category = (AnimalCategory.Fish).ToString();

                Fish fish = new Fish(nickname, age, category, gender, price);
                Fish.Add(fish);
            }

            else if (category == "Bird" || category == "bird")
            {
                category = (AnimalCategory.Bird).ToString();

                Bird bird = new Bird(nickname, age, category, gender, price);
                Birds.Add(bird);
            }

            else
            {
                Console.WriteLine("incorrect input");
                return;
            }
        }

        public void SellPet(int id)
        {
            if (CheckId(id))
            {
                string category = CheckCategory(id);
                switch (category)
                {
                    case "Cat":
                        foreach (var cat in Cats)
                        {
                            if (cat.id == id)
                            {
                                budget += cat.Price;
                                Cats.Remove(cat);
                                return;
                            }
                        }
                        break;

                    case "Dog":
                        foreach (var dog in Dogs)
                        {
                            if (dog.id == id)
                            {
                                budget+= dog.Price;
                                Dogs.Remove(dog);
                                return;
                            }
                        }
                        break;


                    case "Fish":
                        foreach (var fish in Fish)
                        {
                            if (fish.id == id)
                            {
                                budget += fish.Price;
                                Fish.Remove(fish);
                                return;
                            }
                        }
                        break;


                    case "Bird":
                        foreach (var bird in Birds)
                        {
                            if (bird.id == id)
                            {
                                budget += bird.Price;
                                Birds.Remove(bird);
                                return;
                            }
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("Pet with this id is not found!!!");
                return;
            }
        }

        public void BuyFood()
        {
            string category;
            int count;

            foreach (var kvp in FoodDepo)
            {
                Console.WriteLine("Category: {0}, \nPrice: {1}", kvp.Key, kvp.Value);
                Console.WriteLine();
            }


            Console.Write("Enter category(cat/dog/fish/bird food): ");
            category = Console.ReadLine();

            Console.Write("Enter amount: ");
            count = Convert.ToInt32(Console.ReadLine());

            int total_amount;

            if (category == "Cat" || category == "cat")
            {
                total_amount = count * 3;
                if (total_amount <= budget)
                {
                    budget -= total_amount;
                    cat_food += count;
                }
                else
                {
                    Console.WriteLine("You don't have enough money to purchase this amount!!!");
                    return;
                }
            }

            else if (category == "Dog" || category == "dog")
            {
                total_amount = count * 5;
                if (total_amount <= budget)
                {
                    budget -= total_amount;
                    dog_food += count;
                }
                else
                {
                    Console.WriteLine("You don't have enough money to purchase this amount!!!");
                    return;
                }
            }

            else if (category == "Fish" || category == "fish")
            {
                total_amount = count * 4;
                if (total_amount <= budget)
                {
                    budget -= total_amount;
                    fish_food += count;
                }
                else
                {
                    Console.WriteLine("You don't have enough money to purchase this amount!!!");
                    return;
                }
            }

            else if (category == "Bird" || category == "bird")
            {
                total_amount = count * 2;
                if (total_amount <= budget)
                {
                    budget -= total_amount;
                    bird_food += count;
                }
                else
                {
                    Console.WriteLine("You don't have enough money to purchase this amount!!!");
                    return;
                }
            }


        }

        public void calculateTotalMealQuantity()
        {
            string category;
            int total_amount = 0;
            Console.Write("Enter category(cat/dog/fish/bird): ");
            category = Console.ReadLine();

            if (category == "cat" || category == "Cat")
            {
                foreach (var cat in Cats)
                    total_amount += cat.mealQuantity;
            }

            else if (category == "dog" || category == "Dog")
            {
                foreach (var dog in Dogs)
                    total_amount += dog.mealQuantity;
            }

            else if (category == "fish" || category == "Fish")
            {
                foreach (var fish in Fish)
                    total_amount += fish.mealQuantity;
            }

            else if (category == "bird" || category == "Bird")
            {
                foreach (var bird in Birds)
                    total_amount += bird.mealQuantity;
            }

            Console.WriteLine("Total consumed amount: " + total_amount);
        }

        public void calculateTotalPriceofpets()
        {
            string category;
            int total_price = 0;
            Console.Write("Enter category(cat/dog/fish/bird): ");
            category = Console.ReadLine();

            if (category == "cat" || category == "Cat")
            {
                foreach (var cat in Cats)
                    total_price += cat.Price;
            }

            else if (category == "dog" || category == "Dog")
            {
                foreach (var dog in Dogs)
                    total_price += dog.Price;
            }

            else if (category == "fish" || category == "Fish")
            {
                foreach (var fish in Fish)
                    total_price += fish.Price;
            }

            else if (category == "bird" || category == "Bird")
            {
                foreach (var bird in Birds)
                    total_price += bird.Price;
            }

            Console.WriteLine("Total Price: " + total_price);
        }

    }
}
