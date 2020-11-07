namespace Packt.Shared
{
    public partial class Person
    {
        // defined using C# 1-5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // defined using C# 6+ lambda expression
        public string Greeting => $"{Name} says Hello!";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        public string FavouriteIceCream { get; set; }

        private string favouritePrimaryColor;

        public string FavouritePrimaryColor
        {
            get
            {
                return favouritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. " + "Choose from: red, green, blue."
                        );
                }
            }
        }

        // indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }
    }
}