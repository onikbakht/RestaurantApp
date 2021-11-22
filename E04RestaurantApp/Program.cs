using E04RestaurantApp;
string entry="";
int deletedOrders=0;
List<string> orderList = new List<string>();
List<string> readyList = new List<string>();
Food[] Menu ={new Food("Pommes", 2.50),new Food("Burger", 4.50),new Food("Cola  ", 0.85) };
// hier we've defined the food objects of our menu class with their name and price attributes in an array

//showMenu();//
void main()
{
    while (true)
    {
        switch (showMenu())
        {
            case "o":
                createOrder();
                break;
            case "r":
                gotReady();
                break;
            case "e":
                editOrderList();
                break;

        }
    }
}
main();
void editOrderList() {
    int deletNumber;
    if (orderList.Count == 0)
    {
        Console.WriteLine("                 >>>>> the OrderList is empty! <<<<<\n\n");
        main();
    }
    Console.WriteLine("                     >>> select the order which you want to delet<<<\n                     >>>or type main to go back ");
    orderListPresentor();
    entry=Console.ReadLine();

    //bool deletNumberNumeric = int.TryParse(entry, out deletNumber); ;
    //if (entry == "main") { main(); }
    //else if(deletNumberNumeric) {
      //  foreach (string food in orderList)
        ///{
           // string alphabetoutput = "";
            //foreach (char alphabet in food)
            //{
              //  if (alphabet != ')')
                //{
                  //  alphabetoutput = alphabetoutput + alphabet;
                //}
                //else { break; }
            /////}

            //Console.WriteLine("alphabetoutput:   -----     " + alphabetoutput);
            //if (alphabetoutput == deletNumber.ToString())
            //{
              //  Console.WriteLine("anjame hazf-------------------");
              /////
              foreach (string food in orderList) {if(food.StartsWith(entry)){

              /////
                
                orderList.Remove(food);
                Console.WriteLine("               >>>>>>>the chosen order is deleted succesfully!");
                deletedOrders++;
                orderListPresentor();
                main();
                break;
            } }
              Console.WriteLine(">>>  the number you have entered is not in Order List<<<");

            }
            
            
               
                
            
        

        //Console.WriteLine("             >>>  the number you have entered is not in Order List<<<");


    







void gotReady() {
    
    int readyNumber ;
    if (orderList.Count == 0)
    {
        Console.WriteLine("                 >>>>> the OrderList is empty! <<<<<\n\n");
        main();
    }

    orderListPresentor();
    Console.WriteLine("enter the order-number which is ready :\nenter main to go to main menu ");
    entry=Console.ReadLine();
    bool readyNumberNumeric = int.TryParse(entry,out readyNumber);
    // int x = Int32.Parse(str);
    //var isNumeric = int.TryParse("123", out int n);
    if (entry == "main") { main(); }
    else if (readyNumberNumeric )
    {
        foreach (string food in orderList)
        {
            string alphabetoutput = "";
            foreach (char alphabet in food) {
                if (alphabet != ')')
                {
                    alphabetoutput = alphabetoutput + alphabet;
                }
                else { break; }
            }

            Console.WriteLine("alphabetoutput:   -----     "+alphabetoutput);
            if (alphabetoutput == readyNumber.ToString())
            {
                Console.WriteLine("anjame enteghal-------------------");
                readyList.Add(food);
                orderList.Remove(food);

                break;

            }
            else { Console.WriteLine("             >>>  the number you have entered is not in Order List<<<");
                main();
               
            }
        }
        
        Console.WriteLine("done!  order number -" + readyNumber + "- is moved to ReadyList now\n §§§  ready List   §§§  ready List   §§§  ready List   §§§");
        foreach (string red in readyList)
        {
            Console.WriteLine(red);
        }
        ///main();

    }
    else { Console.WriteLine("            >>>> Please enter a CORRECT **NUMBER**!! <<<<\n\n");
        gotReady();
    }
    
}
void createOrder(string Order="",string action="")
{
    Console.WriteLine(" we are in create order------------------------");
    int p = 0, b = 0, c = 0;
    Console.WriteLine("\nto order one pommes type p to order two pommes and one cola type ppc and so on :\nor type main to go to main menu ");
    Order = Console.ReadLine();
    if (Order == "main") { main(); }
    
    for (int i = 0; i < Order.Length; i++)
    {
        
        switch (Order[i])
        {
            case 'p':
                p++;
                break;
            case 'c':
                c++;
                break;
            case 'b':
                b++;
                break;
            default:
                Console.WriteLine("             >>>>>>>>>>>>false oder entry<<<<<<<<\n             >>>>>>>>>>>>you can only enter \"p\" \"b\" \"c\" ");
                main();
                break;
        } }
        
    ///
        
            Console.WriteLine("the order is " + p + " X Pommes and " + b + " X Burger and" + c + " X Cola\nto enter the order type enter enter\nto edit the order type anything");
    if (Console.ReadLine() == "enter"){
        
        double sum = p * Menu[0].price + b * Menu[1].price + c * Menu[2].price;
        int ordNum = orderList.Count() + readyList.Count() + deletedOrders;
        
        orderList.Add((ordNum+")     " + p + "X Pommes  " + b + "X Burger  " + c + "X Cola " + "\nSUM: " + sum.ToString()+"\n"));
        Console.WriteLine(" the order is added succesfully\nthe Orders List : \n");
        orderListPresentor();
    }
    else
    {
        createOrder();
    }
    }

void orderListPresentor()
{
    Console.WriteLine("###  Order list  ###   ###  Order list  ###   ###  Order list  ###");
    foreach (string ord in orderList)
    {
        Console.WriteLine(ord);
    }

}

string showMenu() //show us our menu and the instructions to do the desired actions
{
    Console.WriteLine("***  MENU  ***  MENU  ***   MENU  ***   MENU  ***  MENU  ***");

    foreach (Food food in Menu)
    {
        Console.WriteLine(food.name +"       "+ food.price);
    }
    Console.WriteLine("\n\nchoose the action: \ntype o to creat an order\ntype r to add to the \"got ready\"\ntype e to edit the orderlist") ;
    return Console.ReadLine();
}


//< visibility > <return type > < name > (< parameters >)
//{
//    < function code >
//}