using CafeLaVidaM;

namespace CafeLaVidaDL
{
    public class Orderlist
    {
        List<Model> CafeList = new List<Model>();

        public Orderlist()
        {
            Coffee();
        }
        public void Coffee()
        {
            Model one = new Model
            {
                cafen = "Latte",
                type = "Hot!",
                price = 90,
            };

            CafeList.Add(one);

            Model two = new Model
            {
                cafen = "Macchiato",
                type = "Hot!",
                price = 100,

            };

            CafeList.Add(two);
            Model three = new Model
            {
                cafen = "Mocha",
                type = "Hot!",
                price = 80,
            };

            CafeList.Add(three);
            Model four = new Model
            {
                cafen = "Cappucino",
                type = "Hot!",
                price = 90,
            };

            CafeList.Add(four);
            Model five = new Model
            {
                cafen = "Americano",
                type = "Hot!",
                price = 70,
            };

            CafeList.Add(five);
        }

        public List<Model> GetCafeList()
        {
            return CafeList;
        }

    }
}
