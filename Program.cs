using mis_221_pa_5_sncraven;

DisplayMenu();
static void DisplayMenu(){
    System.Console.WriteLine("choose one of the following ");
    System.Console.WriteLine("1. Manage Trainer Data ");
    System.Console.WriteLine("2. Manage Listing Data ");
    System.Console.WriteLine("3. Manage Customer Booking Data ");
    System.Console.WriteLine("4. Run Reports ");
    System.Console.WriteLine("5. Exit the program");
}

Trainer[] trainers = new Trainer[50];
trainerUtility utility = new trainerUtility(trainers);
utility.GetAllTrainersFromFile();

System.Console.WriteLine("Let's add a trainer");

Listing[] listings = new Listing[50];
listingUtility Utility = new listingUtility(listings);
ListingReport Report = new ListingReport(listings);
Utility.GetAllListingsFromFile();
Report.PrintAllListings();

System.Console.WriteLine("Let's add a listing");


Transaction[] transactions = new Transaction[50];
transactionUtility UTILITY = new transactionUtility(transactions, listings);
TransactionReport report = new TransactionReport(transactions);
UTILITY.GetAllTransactionsFromFile();
report.PrintAllTransactions();

System.Console.WriteLine("Let's add a transaction");
UTILITY.SortbyID();

System.Console.WriteLine("after the sort\n\n\n");
report.PrintAllTransactions();

// report.CustomerPreviousSessions();

System.Console.WriteLine("Control Break Report\n\n\n");
report.SessionsByCustomer();


























 


// extra: trainer sets the rate for each of thier sessions
