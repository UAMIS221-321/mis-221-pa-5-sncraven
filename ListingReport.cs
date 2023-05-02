namespace mis_221_pa_5_sncraven
{
    public class ListingReport 
    {
        Listing[] listings;
        transactionUtility TrUtility;

        listingUtility Lutility;
        public ListingReport(Listing[] listings, transactionUtility TrUtility, listingUtility Lutility)
        {
            this.listings = listings;
            this.TrUtility = TrUtility;
            this.Lutility = Lutility;
            this.listings = Lutility.GetAllListingsFromFile();
        }
        public void PrintAllListings(Listing[] listings)
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                System.Console.WriteLine(listings[i].ToString());
            }
                
        }

        public void HistoricalRevenueReport(Transaction [] transactions, Listing[] listings)
        {
            TrUtility.SortByDate(transactions);
            DateOnly curr = transactions[0].GetTrainingDate(); 
            int currMonth = curr.Month;
            decimal count = listings[0].GetCostOfSession();
            
            for(int i =0; i < Listing.GetCount(); i++)
            {
                if(transactions[i].GetTrainingDate().Month == currMonth)
                {
                    count+= listings[i].GetCostOfSession();
                }
                else
                {
                    ProcessBreak(ref currMonth, ref count, listings[i], transactions[i]);
                }
            }

            ProcessBreak(ref currMonth, ref count);
        }


        public void ProcessBreak(ref  int currMonth, ref decimal count, Listing newListing, Transaction newTransaction)
        {
            System.Console.WriteLine($"{currMonth} \t {count}");
            currMonth = newTransaction.GetTrainingDate().Month;
            count = newListing.GetCostOfSession();
        }
        public void ProcessBreak(ref int currMonth, ref decimal count)
        {
            System.Console.WriteLine($"{currMonth} \t {count}");
        }
    }
}