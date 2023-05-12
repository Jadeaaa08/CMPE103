// BSCPE 1-1 

// Jade Andrie L. Dahan

using System;

class FoodMenu {

    static void Main(string[] args) {
        bool orderComplete = false;
        double totalPrice = 0;
        Console.WriteLine("Welcome to our restaurant! Enjoy our Italian Cuisine");

        while (!orderComplete){

        Console.WriteLine("What would you like to order?");
        Console.WriteLine("Food Menu:");
        Console.WriteLine("1. Lasagne alla Bolognes - $5.99");
        Console.WriteLine("2. Fettuccine al Pomodoro - $6.49");
        Console.WriteLine("3. Gnocchi di Patate - $4.99");
        Console.WriteLine("4. Melanzane alla Parmigiana - $2.99");
        Console.WriteLine("5. Pollo alla Cacciatora - $3.99");
        Console.WriteLine("6. Pizza Margherita - $2.50");
        Console.WriteLine("7. Costoletta alla Milanese - $2.99");
        Console.WriteLine("8. Vitello Tonnato - $2.70");
        Console.WriteLine("9. Back to Menu");

        Console.WriteLine("\nEnter the number of your selection:");
        int choice = int.Parse(Console.ReadLine());
        
        switch (choice) {

            case 1:
               totalPrice+= 5.99; 
                Console.WriteLine("You have selected Lasagne alla Bolognes. That will be $5.99. Enjoy your meal!");
                break;

            case 2:
                totalPrice+= 6.49;
                Console.WriteLine("You have selected Fettuccine al Pomodoro. That will be $6.49. Enjoy your meal!");
                break;

            case 3:
                totalPrice+= 4.99; 
                Console.WriteLine("You have selected Gnocchi di Patate. That will be $4.99. Enjoy your meal!");
                break;

            case 4:
                totalPrice+= 2.99; 
                Console.WriteLine("You have selected Melanzane alla Parmigiana. That will be $2.99. Enjoy your meal!");
                break;

            case 5:
                totalPrice+= 3.99; 
                Console.WriteLine("You have selected Pollo alla Cacciatora. That will be $3.99. Enjoy your meal!");
                break;

            case 6:
                totalPrice+= 2.50; 
                Console.WriteLine("You have selected Pizza Margherita. That will be $2.50. Enjoy your meal!");
                break;

            case 7:
                totalPrice+= 2.99; 
                Console.WriteLine("You have selected Costoletta alla Milanese. That will be $2.99. Enjoy your meal!");
                break;

            case 8:
                totalPrice+= 2.70; 
                Console.WriteLine("You have selected Vitello Tonnato. That will be $2.70 Enjoy your meal!");
                break;

            case 9:
                orderComplete = true;
                break;

                
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;

               
        }
    }    

    } 
}
