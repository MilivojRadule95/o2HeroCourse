﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooClassLibrary.Personel;

namespace ZooAnimalKingdom
{
    public class Cashier : IVisitorProcessor
    {            
        public void ProcessVisitor(Visitor visitor)
        {
            Console.WriteLine("Imma Cashier here");

            CashierOffice.AddProcessed(visitor);

            Console.WriteLine($"Your balance is {visitor.Balance} RSD");

            if (visitor.Balance >= CashierOffice.TicketPrice() && visitor.Age > 7)
            {
                Console.WriteLine($"You may enter {visitor.GetFullName()}, enjoy your visit");
                CashierOffice.AddAccepted(visitor);

                return;
            }
            if (visitor.Balance >= CashierOffice.TicketDiscountPrice() && visitor.Age <= 7)
            {
                Console.WriteLine($"Be careful {visitor.GetFullName()}, and don't feed the animals");
                CashierOffice.AddAccepted(visitor);

                return;
            }

            Console.WriteLine($"Looks like you are short a few bucks");         
        }
    }
}