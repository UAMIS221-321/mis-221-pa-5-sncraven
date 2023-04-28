namespace mis_221_pa_5_sncraven
{
    public class listingUtility
    {
        private Listing[] listings;

        public listingUtility(Listing[] listings) 
        {
            this.listings = listings;
        }

        
        public void GetAllListingsFromFile() // displaying Listin ID, Trainer Name, Date of Session, Time of Session, and the cost of the session
        {
            // open file
            StreamReader inFile = new StreamReader("listing.txt");

             
            string line = inFile.ReadLine(); //process the file //priming read 
            while(line != null) 
            {
                string[] temp = line.Split("#");
                listings[Trainer.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], DateOnly.Parse(temp[2]), TimeSpan.Parse(temp[3]), int.Parse(temp[4]), bool.Parse(temp[5]), bool.Parse(temp[6]), bool.Parse(temp[7]));
                Listing.IncCount();
                line = inFile.ReadLine(); //update read
            }
            inFile.Close(); //close file 

        }

        
        public void AddListing() // adding a listing to the system
        {
            System.Console.WriteLine("Please enter the listing ID number: ");
            Listing myListing = new Listing();
            myListing.SetListingID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the name of the trainer");
            myListing.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date of the session");
            myListing.SetDateOfSession(DateOnly.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the time of the session");
            myListing.SetTimeOfSession(TimeSpan.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the cost of the session");
            myListing.SetCostOfSession(int.Parse(Console.ReadLine()));

            listings[Trainer.GetCount()] = myListing; //putting it in the last available spot in the array
            Trainer.IncCount();
            

            Save(); 
        }
        
        public void Save() // saving the added trainer & info of the trainer
        {
            StreamWriter outFile = new StreamWriter("listing.txt"); // open file 

            for(int i = 0; i < Trainer.GetCount(); i++) //process the file & priming read 
            {
                outFile.WriteLine(listings[i].ToString());
            }
            outFile.Close(); //closing the file 
        }

        private int Find(string searchVal) //finding a trainer
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetTrainerName().ToUpper() == searchVal.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        public void UpdateListing() //updating the trainer's information 
        {
            System.Console.WriteLine("what is the name of the listing you would like to update ");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);
            if(foundIndex != -1) 
            {
                System.Console.WriteLine("Please enter the trainer ID number: ");
                listings[foundIndex].SetListingID(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the name of the trainer");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the date of the session");
                listings[foundIndex].SetDateOfSession(DateOnly.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the time of the session");
                listings[foundIndex].SetTimeOfSession(TimeSpan.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the cost of the session");
                listings[foundIndex].SetCostOfSession(int.Parse(Console.ReadLine()));

                Save(); // saving trainer's info to file 
            }
            else 
            {
                System.Console.WriteLine("The listing was not found"); // if the listing was not found, display "the listing was not found"
            }
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
