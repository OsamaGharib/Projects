using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------|ATM Simulator|---------------------");
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine("===============================================================");
            Console.WriteLine("===================Please Enter Your Card======================");
            lable1:
            Console.WriteLine("Please enter your password");
            string userpass = Console.ReadLine();
            string correctPass = "Osama Gharib";
            
            if (userpass== correctPass)
            {
                
                Console.WriteLine("Welcome Mr Osama Gharib");
                
                Console.WriteLine("If You want the language is english press type \"1\"");
                string langtype = Console.ReadLine();
                if (langtype=="1")
                {
                    Console.WriteLine("Machine will be in English");
                    Console.WriteLine("Choose An account type\n1-Current\n2-Savings\n3-Credit");
                    string accounttype = Console.ReadLine();
                        if (accounttype=="1")
                    {
                        Console.WriteLine("You Choosed Current Account Type!");
                        Console.WriteLine("Please Enter The Amount You need");
                        int money = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Here you are {0:C}", money);
                        Console.WriteLine("If You want any banking services else press y if you dont press n");
                        
                        char tryservice = Convert.ToChar(Console.ReadLine());
                        if (tryservice == 'y')
                        {
                            goto lable1;
                        }
                        else if (tryservice == 'n')
                        {
                            goto lable2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            goto lable1;
                        }

                    }
                        if (accounttype == "2")
                    {
                        Console.WriteLine("You Choosed Savings Account Type!");
                        Console.WriteLine("Please Enter The Amount You need");
                        int money2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Here you are {0:C}", money2);
                        Console.WriteLine("If You want any banking services else press y if you dont press n");
                        Console.WriteLine("If You want any banking services else press y if you dont press n");
                        char tryservice = Convert.ToChar(Console.ReadLine());
                        if (tryservice == 'y')
                        {
                            goto lable1;
                        }
                        else if (tryservice == 'n')
                        {
                            goto lable2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            goto lable1;
                        }
                    }
                        if (accounttype == "3")
                    {
                        Console.WriteLine("You Choosed Credit Account Type!");
                        Console.WriteLine("Please Enter The Amount You need");
                        int money3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Here you are {0:C}", money3);
                        Console.WriteLine("If You want any banking services else press y if you dont press n");
                        char tryservice = Convert.ToChar(Console.ReadLine());
                        if (tryservice=='y')
                        {
                            goto lable1;
                        }
                        else if (tryservice=='n')
                        {
                            goto lable2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            goto lable1;
                        }
                    }
                }
                
                else
                {
                    Console.WriteLine("Invalid Input");
                    goto lable1;
                }
            }
            else
            {
                for (int i=1;i<=3;i++)
                {
                    Console.WriteLine("Invalid password you have 3 more chances to enter the right password");
                    string tryPass=Console.ReadLine();
                    if (userpass == correctPass)
                    {
                        goto lable1;
                    }

                    
                }
            }
            lable2:
            Console.WriteLine("Thanks A Lot");
        }
    }
}
