using mis_221_pa_5_sncraven;



Trainer[] trainers = new Trainer[50];
trainerUtility Tutility = new trainerUtility(trainers);
trainers = Tutility.GetAllTrainersFromFile();

Listing[] listings = new Listing[50];
listingUtility Lutility = new listingUtility(listings);
listings = Lutility.GetAllListingsFromFile();

Transaction[] transactions = new Transaction[50];
transactionUtility TrUtility = new transactionUtility(transactions, listings);
transactions = TrUtility.GetAllTransactionsFromFile();

ListingReport Lreport = new ListingReport(listings, TrUtility, Lutility);
Lutility.GetAllListingsFromFile();
System.Console.WriteLine("After the sort \n\n\n");
Lreport.PrintAllListings(listings);
System.Console.WriteLine("Control Break Report\n\n\n");
Lreport.HistoricalRevenueReport(transactions, listings);

TransactionReport TrReport = new TransactionReport(transactions);
System.Console.WriteLine("after the sort\n\n\n");
TrReport.PrintAllTransactions();

System.Console.WriteLine("Control Break Report \n\n\n");
TrReport.IndividualCustomerSessionsReport(transactions);
TrReport.HistoricalCustomerSessionsReport(transactions);


string userInput = GetMenuChoice();
while (userInput != "5") {
    Route(userInput);
    userInput = GetMenuChoice();
}
// end main

static string GetMenuChoice(){
    DisplayMenu();
    string userInput = Console.ReadLine();

    while(!ValidMenuChoice(userInput)){
        System.Console.WriteLine("invalid menu choice. please enter a valid menu choice");
        System.Console.WriteLine("press any key to continue ");
        Console.ReadKey();

        DisplayMenu();
        userInput = Console.ReadLine();
    }
    return userInput;
}

static bool ValidMenuChoice(string userInput){
    if(userInput == "1" || userInput == "2" || userInput == "3" || userInput =="4" || userInput =="5")
    {
        return true;
    }
    return false;
}

void Route(string userInput){
    if(userInput == "1"){
        RouteTrainer();
    }
    else if(userInput == "2"){
        RouteListing();
    }
    else if(userInput == "3"){
        RouteBooking();
    }
    else if(userInput == "4"){
        RouteReports();
    }
    else if(userInput == "5"){

    }
    else if(userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4"){
        System.Console.WriteLine("invalid");
    }
}
void RouteTrainer()

{

    System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a trainer\n Please enter 4 to exit ");
    string userChoiceTrainer = Console.ReadLine();
    while(userChoiceTrainer != "4") 
    {
        if(userChoiceTrainer == "1")
        {
            Tutility.GetAllTrainersFromFile();
            Tutility.AddTrainer();
            
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a trainer");
            userChoiceTrainer = Console.ReadLine();
            
        }
        else if(userChoiceTrainer == "2")
        {
            Tutility.GetAllTrainersFromFile();
            Tutility.UpdateTrainer();
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a trainer");
            userChoiceTrainer = Console.ReadLine();
        }
        else if(userChoiceTrainer == "3")
        {
            Tutility.GetAllTrainersFromFile();
            Tutility.DeleteTrainer();
            System.Console.WriteLine("Please enter the ID number of the trainer you would like to delete");
            Tutility.DeleteTrainer();
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a trainer");
            userChoiceTrainer = Console.ReadLine();
        }
        else if(userChoiceTrainer == "4")
        {

        }
        else if(userChoiceTrainer != "1" && userChoiceTrainer != "2" && userChoiceTrainer !="3" && userChoiceTrainer != "4")
        {
            System.Console.WriteLine("invalid");
        }
    }
}
void RouteListing()
{
    System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a listing\n please enter 4 to exit");
    string userChoiceListing = (Console.ReadLine());
    while(userChoiceListing != "4") 
    {
    if(userChoiceListing == "1")
        {
            Lutility.GetAllListingsFromFile();
            Lutility.AddListing();
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a listing");
            userChoiceListing = Console.ReadLine();
        }
        else if(userChoiceListing == "2")
        {
            Lutility.GetAllListingsFromFile();
            Lutility.UpdateListing();
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a listing");
            userChoiceListing = Console.ReadLine();
        }
        else if(userChoiceListing == "3")
        {
            Lutility.GetAllListingsFromFile();
            Lutility.DeleteListing();
            System.Console.WriteLine("Please enter the ID number of the trainer you would like to delete");
            Lutility.DeleteListing();
            
            System.Console.WriteLine("Please enter 1 to add a trainer\nPlease enter 2 to edit a trainer\nPlease enter 3 to delete a listing");
            userChoiceListing = Console.ReadLine();
        }
        else if(userChoiceListing == "4")
        {

        }

        else if(userChoiceListing != "1" && userChoiceListing != "2" && userChoiceListing !="3" && userChoiceListing != "4")
        {
            System.Console.WriteLine("invalid");
        }
        
    }
}
void RouteBooking()
{
    Lutility.GetAllListingsFromFile();
    System.Console.WriteLine("Please enter the id of the listing you would like to book");
    TrUtility.BookASession();
    
    
}
void RouteReports()
{
    System.Console.WriteLine("Please enter 1 to get the Historical Revenue Report\nPlease enter 2 to get the Individual Customer Report\nPlease enter 3 to get the historical customer report\nPlease enter 4 to exit ");
    string userChoiceReport = (Console.ReadLine());
    while(userChoiceReport != "4")
    {
        if(userChoiceReport == "1")
        {
            Lreport.HistoricalRevenueReport(transactions, listings);
            System.Console.WriteLine("Please enter 1 to get the Historical Revenue Report\nPlease enter 2 to get the Individual Customer Report\nPlease enter 3 to get the historical customer report");
            userChoiceReport = Console.ReadLine();
        }
        else if(userChoiceReport == "2")
        {
            TrReport.IndividualCustomerSessionsReport(transactions);
             System.Console.WriteLine("Please enter 1 to get the Historical Revenue Report\nPlease enter 2 to get the Individual Customer Report\nPlease enter 3 to get the historical customer report");
            userChoiceReport = Console.ReadLine();
            
        }
        else if(userChoiceReport == "3")
        {
            TrReport.HistoricalCustomerSessionsReport(transactions);
             System.Console.WriteLine("Please enter 1 to get the Historical Revenue Report\nPlease enter 2 to get the Individual Customer Report\nPlease enter 3 to get the historical customer report");
            userChoiceReport = Console.ReadLine();
        }
        else if(userChoiceReport == "4")
        {

        }
        else if(userChoiceReport != "1" && userChoiceReport != "2" && userChoiceReport !="3" && userChoiceReport != "4")
        {
            System.Console.WriteLine("invalid");
        }
    }
}

static void DisplayMenu(){


    System.Console.WriteLine("Welcome to Train Like A Champion -- Personal Fitness");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("choose one of the following");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("1. Manage Trainer Data");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("2. Manage Listing Data");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("3. Manage Customer Booking Data");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("4. Run Reports");
    System.Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);
    System.Console.WriteLine("5. Exit the program");
}
































 



