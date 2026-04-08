using OOP_Assignment_3.Assignments_03.BookingTicket.Inheritance.Assignments_03.BookingTicket.Inheritance;
using System.IO;
using System.Net.Sockets;
using System.Xml.Linq;

namespace OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Question 01


            //    a) Composition

            //    b) Association

            //    c) Inheritance

            //    d) Aggregation

            //    e) Dependency 
            #endregion

            #region Question 02
            //Question 02




            //        a)

            //        Yes, a child class in a different assembly can access a protected member if it inherits from the parent.

            //        It cannot be accessed from outside the class via an object instance.


            //        b)

            //        protected internal → Accessible within the same assembly or via inheritance.


            //        private protected → Accessible only within the same assembly and via inheritance.


            //        c)

            //        sealed class → Cannot be inherited from.

            //        sealed method → ​​Cannot be overridden in a child class.


            //        d)

            //        Yes, an object can be created from a sealed class using `new`.

            //        However, it cannot inherit from a sealed class. 
            #endregion


            #region Progect
            //namespace Assignments_03.BookingTicket.Inheritance
            //    {
            //        internal class Cinema
            //        {
            //            public string CinemaName { get; set; }

            //            private Projector p = new Projector();

            //            private Ticket[] tickets = new Ticket[20];

            //            public Cinema(string name)
            //            {
            //                CinemaName = name;

            //            }

            //            public void AddTicket(Ticket t)
            //            {
            //                for (int i = 0; i < tickets.Length; i++)
            //                {
            //                    if (tickets[i] == null)
            //                    {
            //                        tickets[i] = t;
            //                        return;
            //                    }
            //                }
            //                Console.WriteLine("Cinema is Full");
            //            }


            //            public void PrintAllTickets()
            //            {
            //                Console.WriteLine("\n========== All Tickets ==========");

            //                foreach (var t in tickets)
            //                {
            //                    if (t != null)
            //                        Console.WriteLine(t);
            //                }
            //                Console.WriteLine("\n========== Statistics ==========");
            //                Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
            //            }

            //            public void OpenCinema()
            //            {
            //                Console.WriteLine("\n========== Cinema Opened ==========");
            //                p.Start();
            //            }

            //            public void CloseCinema()
            //            {
            //                Console.WriteLine("\n========== Cinema Closed ==========");
            //                p.Stop();
            //            }




            //namespace Assignments_03.BookingTicket.Inheritance
            //    {
            //        internal class IMAXTicket : Ticket
            //        {
            //            public bool Is3D { get; set; }

            //            public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, is3D ? price + 30 : price)
            //            {
            //                Is3D = is3D;

            //            }

            //            public override string ToString()
            //            {
            //                return base.ToString() + $" | IMAX 3D : {(Is3D ? "Yes" : "No")}";
            //            }



            //namespace Assignments_03.BookingTicket.Inheritance
            //    {
            //        internal class Projector
            //        {

            //            public void Start()
            //            {
            //                Console.WriteLine("Projector Started.");
            //            }
            //            public void Stop()
            //            {
            //                Console.WriteLine("Projector Stopped.");


            //            //            }
            //namespace Assignments_03.BookingTicket.Inheritance
            //    {
            //        internal class StandardTicket : Ticket

            //        {
            //            public string seatNumber { get; set; }
            //            public StandardTicket(string movieName, decimal price, string seat) : base(movieName, price)
            //            {
            //                seatNumber = seat;

            //            }
            //            public override string ToString()
            //            {
            //                return base.ToString() + $"| seat : {seatNumber}";
            //            }


            //        }

            //    }
            //    }
        }
        //    internal class VIPTicket : Ticket
        //    {
        //        public bool LoungeAccess { get; set; }

        //        public decimal ServiceFee { get; } = 50;
        //        public VIPTicket(string movieName, decimal price, bool louAccs) : base(movieName, price + 50)
        //        {

        //            LoungeAccess = louAccs;
        //        }

        //        public override string ToString()
        //        {
        //            return base.ToString() + $" | Lounge : {(LoungeAccess ? "Yes" : "No")} | Service Fee : {ServiceFee}EGP";
        //        }



        //    } internal class Ticket
    {

    //    public string MovieName { get; set; }
    //    public decimal Price { get; private set; }

    //    public int TicketId { get; }

    //    private static int counter = 0;

    //    public Ticket(string movieName, decimal price)
    //    {
    //        if (price <= 0)
    //        {
    //            throw new ArgumentException("Price must be greater than zero.");
    //        }





    //        MovieName = movieName;
    //        Price = price;

    //        counter++;
    //        TicketId = counter;


    //    }

    //    public static int GetTotalTickets()
    //    {
    //        return counter;
    //    }

    //    public decimal PriceAfterTax()
    //    {
    //        return Price * 1.14m;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Ticket #{TicketId} | {MovieName} | Price : {Price} EGP | After Tax : {PriceAfterTax} EGP |";
    //    }




    //}



    //}namespace Assignments_03
{
        //    #endregion


        //    Cinema c1 = new Cinema("City Cinema");
        //c1.OpenCinema();



        //    Ticket t1 = new StandardTicket("Inception", 120, "A-5");

        //Ticket t2 = new VIPTicket("Avengers", 200, true);

        //Ticket t3 = new IMAXTicket("Dune", 180, false);




        //c1.AddTicket(t1);

        //    c1.AddTicket(t2);
            
        //    c1.AddTicket(t3);

        //    c1.PrintAllTickets();

        //    c1.CloseCinema();



}
        #endregion