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
        public void CustomerPreviousSessions()
        {
            System.Console.WriteLine("Please enter in an email address");
            string curr = transactions[0].GetSession();
            int count = transactions[0].GetSessionID();
            for(int i = 0; i < Transaction.GetCount(); i++)
            {
                if(transactions[i].GetSession() == curr)
                {
                    count += transactions[i].GetSessionID();
                }else
                {
                    ProcessBreak(ref curr, ref count, transactions[i]);
                }
            }
            ProcessBreak(ref curr, ref count);
        }
        // Getting a list of the sessions sorted by customer and then by the training date
        public void SessionsByCustomer()
        {
            string curr = transactions[0].GetCustomerName();
            DateOnly cur = transactions[0].GetTrainingDate();
            int count = transactions[0].GetSessionID();
            for(int i = 0; i < Transaction.GetCount();i++)
            {
                if(transactions[i].GetCustomerName() == curr)
                {
                    count += transactions[i].GetSessionID();
                }else if(transactions[i].GetTrainingDate() == cur)
                {
                    count += transactions[i].GetSessionID();
                }else 
                {
                    ProcessBreak(ref curr, ref cur, ref count, transactions[i]);
                }
            }
            ProcessBreak(ref curr, ref cur, ref count);
        }
        // control break 
        
        public void ProcessBreak(ref string curr, ref DateOnly cur, ref int count, Transaction newTransaction)
        {
            System.Console.WriteLine($"{curr} \t{cur}\t{count}");
            curr = newTransaction.GetCustomerName();
            cur = newTransaction.GetTrainingDate();
            count = newTransaction.GetSessionID();
            
        }
        //  control break 
        public void ProcessBreak(ref string curr, ref DateOnly cur, ref int count)
        {
            System.Console.WriteLine($"{curr} \t{cur}\t {count}");
        }
        public void ProcessBreak(ref string curr, ref int count, Transaction newTransaction)
        {
            System.Console.WriteLine($"{curr} \t {count}");
            curr = newTransaction.GetSession();
            count = newTransaction.GetSessionID();
        }
        public void ProcessBreak(ref string curr, ref int count)
        {
            System.Console.WriteLine($"{curr} \t {count}");
        }
    }

}