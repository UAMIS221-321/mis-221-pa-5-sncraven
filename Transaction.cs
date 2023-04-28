using System.ComponentModel.Design.Serialization;
namespace mis_221_pa_5_sncraven
{
    public class Transaction
    {
        // instance variables
        private int sessionID;
        private string session;
        private string customerName;
        private string customerEmail;
        private DateOnly trainingDate;
        private int trainerID;
        private string trainerName;
        
        static private int count; 
        // no arg constructor
        public Transaction()
        {

        }

        // arg constructor
        public Transaction(int sessionID, string session, string customerName, string customerEmail, DateOnly trainingDate, int trainerID, string trainerName) {
            this.sessionID = sessionID;
            this.session = session;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            
        }
        // accessor methods 
        
        public int GetSessionID() { 
            return sessionID;
        }
        public void SetSessionID(int sessionID) {
            this.sessionID = sessionID;
        }
        public string GetSession()
        {
            return session;
        }
        public void SetSession(string session)
        {
            this.session = session;
        }
        public string GetCustomerName() {
            return customerName;
        }
        public void SetCustomerName(string customerName) {
            this.customerName = customerName;
        }
        public string GetCustomerEmail() {
            return customerEmail;
        }
        public void SetCustomerEmail(string customerEmail) {
            this.customerEmail = customerEmail;
        }
        public DateOnly GetTrainingDate() {
            return trainingDate;
        }
        public void SetTrainingDate (DateOnly trainingDate) {
            this.trainingDate = trainingDate;
        }
        public int GetTrainerID() {
            return trainerID;
        }
        public void SetTrainerID(int trainerID) {
            this.trainerID = trainerID;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }
        
        static public int GetCount() {
            return count;
        }
        static public void SetCount(int count) {
            Transaction.count = count;
        }
        static public void IncCount() {
            Transaction.count++;
        }
        // public string ToReportString()
        // {
        //     return 
        // }

        public override string ToString()
        {
                return $"{sessionID}#{session}#{customerName}#{trainingDate}#{trainerID}#{trainerName} has been completed";

        }
    }

}