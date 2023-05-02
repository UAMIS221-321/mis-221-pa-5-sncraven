namespace mis_221_pa_5_sncraven
{
    public class TransactionReport
    {
        Transaction[] transactions;
        public TransactionReport(Transaction[] transactions)
        {
            this.transactions = transactions;
        }
        // print all of the transactions that are inputed 
        public void PrintAllTransactions()
        {
            for(int i = 0; i < Transaction.GetCount(); i++)
            {
                System.Console.WriteLine(transactions[i].ToString());
            }
        }
        
        //prompting user for an email address & returning the previous training sessions for the customer
        public void IndividualCustomerSessionsReport(Transaction[] transactions) 
        {
            
            System.Console.WriteLine("Please enter in an email address");
            string customerEmail = Console.ReadLine();

            System.Console.WriteLine("Previous training sessions from customer with email :" + customerEmail);
            for(int i = 0; i < Transaction.GetCount(); i++)
            {
                if(transactions[i].GetSession() == customerEmail)
                {
                    System.Console.WriteLine();
                }   
            }    
        }
       
            
        
        // Getting a list of the sessions sorted by customer and then by the training date
        public void HistoricalCustomerSessionsReport(Transaction[] transactions)
        {
            string curr = transactions[0].GetCustomerName();
            DateOnly cur = transactions[0].GetTrainingDate();
            string count = transactions[0].GetSession();
            for(int i = 0; i < Transaction.GetCount();i++)
            {
                if(transactions[i].GetCustomerName() == curr)
                {
                    count += transactions[i].GetSession();
                }else if(transactions[i].GetTrainingDate() == cur)
                {
                    count += transactions[i].GetSession();
                }else 
                {
                    HistoricalProcessBreak(ref curr, ref cur, ref count, transactions[i]);
                }
            }
            HistoricalProcessBreak(ref curr, ref cur, ref count);
        }
        // control break 

       
        
        public void HistoricalProcessBreak(ref string curr, ref DateOnly cur, ref string count, Transaction newTransaction) // control break for Historical Customer Session Report 
        {
            System.Console.WriteLine($"{curr} \t{cur}\t{count}");
            curr = newTransaction.GetCustomerName();
            cur = newTransaction.GetTrainingDate();
            count = newTransaction.GetSession();
            
        }
 
        
        public void HistoricalProcessBreak(ref string curr, ref DateOnly cur, ref string count)
        {
            System.Console.WriteLine($"{curr} \t{cur}\t {count}");
        }
        
    }

}