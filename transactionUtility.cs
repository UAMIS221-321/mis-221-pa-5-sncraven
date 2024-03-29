namespace mis_221_pa_5_sncraven
{
    public class transactionUtility
    {
        private Transaction[] transactions;
        private Listing[] listings;

        public transactionUtility(Transaction[] transactions, Listing[] listings)
        {
            this.transactions = transactions;
            this.listings = listings;
            GetAllTransactionsFromFile();
        }
        

        
        public Transaction[] GetAllTransactionsFromFile() // getting the transaction from a text file 
        {
            
            StreamReader inFile = new StreamReader("transactions.txt"); // open the transaction file 

            
            Transaction.SetCount(0);
            string line = inFile.ReadLine(); // priming read
            while(line != null) // process file 
            {
                string[] temp = line.Split('#');
                transactions[Transaction.GetCount()] = new Transaction(int.Parse(temp[0]), temp[1], temp[2], temp[3],DateOnly.Parse(temp[4]), int.Parse(temp[5]), temp[6]);
                Transaction.IncCount();
                System.Console.WriteLine(Transaction.GetCount());
                line = inFile.ReadLine(); // update read
            }
            
            inFile.Close(); // close the transaction file 
            return transactions;
        }
    
        
        public Transaction[] BookASession() // Prompting the user to input new booking information and recording it
        {
            
            PrintAllSessions();
            System.Console.WriteLine("Please enter the session ID of the session you want to book");
            int searchVal = int.Parse(Console.ReadLine());
            int foundSession = FindSession(searchVal);

            if(foundSession != -1)
            {
                System.Console.WriteLine("Please enter your name");
                transactions[Transaction.GetCount()].SetCustomerName(Console.ReadLine());
                System.Console.WriteLine("Please enter you email address");
                transactions[Transaction.GetCount()].SetCustomerEmail(Console.ReadLine());
                transactions[Transaction.GetCount()].SetTrainingDate(listings[foundSession].GetDateOfSession());
                transactions[Transaction.GetCount()].SetTrainerID(listings[foundSession].GetListingID());
                transactions[Transaction.GetCount()].SetTrainerName(listings[foundSession].GetTrainerName());

                SaveSession();
            }
            if(foundSession == -1)
            {
                System.Console.WriteLine("I'm sorry but the session is booked. :(");
            }
            else{
                System.Console.WriteLine("The session you were looking for was not found");
            }
            return transactions;
        }
        
        public void PrintAllSessions()
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetStatus() == false) 
                {
                System.Console.WriteLine(transactions[i].ToString());
                }

            }
        }
        private void SaveSession() // saving the new booking to a text file 
        {
            StreamWriter outFile = new StreamWriter("transaction.txt"); // opening the file
            
            for(int i = 0; i < Transaction.GetCount(); i++) // process file 
            {
                outFile.WriteLine(transactions[i].ToFile());
            }
            outFile.Close(); // closing the file 
        }
        
        public int FindSession(int searchVal) // finding the transaction in the file
        {
            for(int i = 0; i < Transaction.GetCount(); i++)
            {
                if(transactions[i].GetSessionID() == searchVal)
                {
                    return i;
                }
            }

            return -1;
        }
    
        public void SortbyID()  // sorting the transaction File by session ID's
        {
            for(int i = 0; i < Transaction.GetCount(); i++)
            {
                int min = i;
                for(int j =0; j < Transaction.GetCount(); j++)
                {
                    if(transactions[j].GetSessionID().CompareTo(transactions[min].GetSessionID()) < 0)
                    {
                        min = j;
                    }
                }
                if(min!= i)
                {
                    Swap(min, i);
                }
            }
        }
        
        public void SortByDate(Transaction[] transactions)
        {
            for(int i = 0; i < Transaction.GetCount() -1; i++)
            {
                int min = i;
                for(int j = 0; j < Transaction.GetCount(); j++)
                {
                    if(transactions[j].GetTrainingDate().CompareTo(transactions[min].GetTrainingDate()) < 0 || 
                    (transactions[j].GetCustomerName() == transactions[min].GetCustomerName() && transactions[j].GetTrainingDate() < (transactions[min].GetTrainingDate()))) 
                    {
                        min = j;
                    }
                }
                if(min!= i)
                {
                    Swap(min, i);
                }
            }
        }
        
        public void Swap(int x, int y)
        {
            Transaction temp = transactions[x];
            transactions[x] = transactions[y];
            transactions[y] = temp;
        }    
    }
}