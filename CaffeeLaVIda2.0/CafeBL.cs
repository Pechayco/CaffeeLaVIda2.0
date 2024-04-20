using CafeLaVidaDL;
using CafeLaVidaM;
using System;

namespace CaffeeLaVidaBL
{
    public class CafeBL
    {

        public List<Model> coffees = new List<Model>();
        public List<Model> GetDrinktionary()
        {
            Orderlist dataServices = new Orderlist();
            return dataServices.GetCafeList();
        }
        public void Addcoffees(Model coffee)
        {
            coffees.Add(coffee);
        }
        public void Deletecoffees(Model coffee)
        {
            coffees.Remove(coffee);
        }
    }
}

