﻿using CafeLaVidaDL;
using CafeLaVidaDL;
using CafeLaVidaM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeUI
{
    public class Counter
    {
        public static void ShowHistory(Model coffees)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Here's your Drink!");
            Console.WriteLine(coffees.cafen);
            Console.WriteLine(coffees.type);

            Console.WriteLine("-----------------------");

        }
        static void Main(string[] args)
        {

            Orderlist businessServices = new Orderlist();
            List<Model> CafeList = businessServices.GetCafeList();


            Console.WriteLine("Please Choose an Option");
            Console.WriteLine("1.CafeList");
            Console.WriteLine("2.Add to CafeList");

            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)

            {
                case 1:

                    Console.WriteLine("Welcome to Cafe La Vida");
                    Console.WriteLine("Choose your Drink");
                    Console.WriteLine("------------------");
                    Console.WriteLine("1. Latte");
                    Console.WriteLine("2. Macchiato");
                    Console.WriteLine("3. Mocha");
                    Console.WriteLine("4. Cappucino");
                    Console.WriteLine("5. Americano");
                    Console.WriteLine("------------------");

                    int drinknumber = Convert.ToInt32(Console.ReadLine());
                    switch (drinknumber)
                    {
                        case 1:
                            ShowHistory(CafeList[0]);
                            break;
                        case 2:
                            ShowHistory(CafeList[1]);
                            break;
                        case 3:
                            ShowHistory(CafeList[2]);
                            break;
                        case 4:
                            ShowHistory(CafeList[3]);
                            break;
                        case 5:
                            ShowHistory(CafeList[4]);
                            break;
                        default:
                            Console.WriteLine("UNIDENTIFIED DRINK NUMBER");
                            break;
                    }
                    break;

                case 2:

                    Model userip = new Model();

                    Console.WriteLine("Enter Cocktail Name");
                    userip.cafen = Console.ReadLine();
                    Console.WriteLine("Enter Prep");
                    userip.type = Console.ReadLine();
                    

                    ShowHistory(CafeList[0]);
                    ShowHistory(CafeList[1]);
                    ShowHistory(CafeList[2]);
                    ShowHistory(CafeList[3]);
                    ShowHistory(CafeList[4]);
                    Console.WriteLine("\nHere's your added Drink!\n");
                    ShowHistory(userip);

                    break;

                default:
                    Console.WriteLine("ERROR IN CHOOSING");
                    break;


            }
        }






    }


}