namespace mis_221_pa_5_sncraven
{
    public class listingUtility
    {
        private Listing[] listings;

        public listingUtility(Listing[] listings) 
        {
            this.listings = listings;
        }

        
        public Listing[] GetAllListingsFromFile() // displaying Listin ID, Trainer Name, Date of Session, Time of Session, and the cost of the session
        {
            // open file
            StreamReader inFile = new StreamReader("listing.txt");

            Listing.SetCount(0);
            string line = inFile.ReadLine(); //process the file //priming read 
            while(line != null) 
            {
                string[] temp = line.Split("#");
                listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], DateOnly.Parse(temp[3]), TimeSpan.Parse(temp[4]), decimal.Parse(temp[5]));
                Listing.IncCount();
                line = inFile.ReadLine(); //update read
            }
            
            inFile.Close(); //close file 
            return listings;
        }

        
        public Listing[] AddListing() // adding a listing to the system
        {
            System.Console.WriteLine("Please enter the listing ID number: ");
            Listing myListing = new Listing();
            myListing.SetListingID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the name of the trainer");
            myListing.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter in the session type");
            myListing.SetSessionType(Console.ReadLine());
            System.Console.WriteLine("Please enter the date of the session");
            myListing.SetDateOfSession(DateOnly.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the time of the session");
            myListing.SetTimeOfSession(TimeSpan.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the cost of the session");
            myListing.SetCostOfSession(decimal.Parse(Console.ReadLine()));

            listings[Listing.GetCount()] = myListing; //putting it in the last available spot in the array
            Listing.IncCount();
            Listing.IncMax();

            SaveListing();
            return listings; 
        }
        
        public void SaveListing() // saving the added trainer & info of the trainer
        {
            StreamWriter outFile = new StreamWriter("listing.txt"); // open file 

            for(int i = 0; i < Listing.GetCount(); i++) //process the file & priming read 
            {
                outFile.WriteLine(listings[i].ToFile());
            }
            outFile.Close(); //closing the file 
        }

        public int FindListing(int searchVal) //finding a trainer
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetListingID() == searchVal)
                {
                    return i;
                }
            }
            return -1;
        }
        public Listing[] UpdateListing() //updating the trainer's information 
        {
            System.Console.WriteLine("what is the name of the listing you would like to update ");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = FindListing(searchVal);
            if(foundIndex != -1) 
            {
                System.Console.WriteLine("Please enter the trainer ID number: ");
                listings[foundIndex].SetListingID(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the name of the trainer");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter in the session type");
                listings[foundIndex].SetSessionType(Console.ReadLine());
                System.Console.WriteLine("Please enter the date of the session");
                listings[foundIndex].SetDateOfSession(DateOnly.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the time of the session");
                listings[foundIndex].SetTimeOfSession(TimeSpan.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the cost of the session");
                listings[foundIndex].SetCostOfSession(decimal.Parse(Console.ReadLine()));

                SaveListing(); // saving trainer's info to file 
            }
            else 
            {
                System.Console.WriteLine("The listing was not found"); // if the listing was not found, display "the listing was not found"
            }
            return listings;
        }
        public Listing[] DeleteListing()
        {
            listings = GetAllListingsFromFile();
            System.Console.WriteLine("What is the Listing ID of the trainer you want to delete?");
            int searchVal = int.Parse(Console.ReadLine());
            int foundListing = FindListing(searchVal);
            if(foundListing != -1)
            {
                listings[foundListing].SetDeleted(true);
                SaveListing();
                listings = GetAllListingsFromFile();
                System.Console.WriteLine("Listing was deleted");
            }
            else 
            {
                System.Console.WriteLine("The listing was not found");
            }
            return listings;
        }

        

        public void Sort() // sorting the listings in the file 
        {
            for(int i = 0; i < Listing.GetCount() -1; i++)
            {
                int min = i;
                for(int j = i + 1; j < Listing.GetCount(); j++)
                {
                    if(listings[j].GetTrainerName().CompareTo(listings[min].GetTrainerName()) < 0 || 
                    (listings[j].GetTrainerName() == listings[min].GetTrainerName() && listings[j].GetListingID() < listings[min].GetListingID()))
                    {
                        min = j;
                    }
                    if(min != j)
                    {
                        Swap(min,i);
                    }
                }
                
            }
        }
        private void Swap(int x, int y)
        {
            Listing temp = listings[x];
            listings[x] = listings[y];
            listings[y] = temp;
        }

    }
}
