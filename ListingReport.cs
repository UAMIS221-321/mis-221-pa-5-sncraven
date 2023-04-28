namespace mis_221_pa_5_sncraven
{
    public class ListingReport
    {
        Listing[] listings;
        public ListingReport(Listing[] listings)
        {
            this.listings = listings;
        }
        public void PrintAllListings()
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                System.Console.WriteLine(listings[i].ToString());
            }
                
        }

        public void GetListingRevenue()
        {
            DateOnly curr = listings[0].GetDateOfSession();
            int count = listings[0].GetListingID();
            for(int i =0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetDateOfSession() == curr)
                {
                    count += listings[i].GetListingID();
                }else 
                {
                    ProcessBreak(ref curr, ref count, listings[i]);
                }
            }
            ProcessBreak(ref curr, ref count);
        }

        public void ProcessBreak(ref DateOnly curr, ref int count, Listing newListing)
        {
            System.Console.WriteLine($"{curr} \t {count}");
            curr = newListing.GetDateOfSession();
            count = newListing.GetListingID();
        }
        public void ProcessBreak(ref DateOnly curr, ref int count)
        {
            System.Console.WriteLine($"{curr} \t {count}");
        }
    }
}