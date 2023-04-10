namespace mis_221_pa_5_sncraven
{
    public class Transaction
    {
        // instance variables
        private int sessionID;
        private string customerName;
        private string customerEmail;
        private DateTime trainingDate;
        private int trainerID;
        private string trainerName;
        private string status;

        // arg constructor
        public Transaction(int sessionID, string customerName, string customerEmail, DateTime trainingDate, int trainerID, string trainerName, string status) {
            this.sessionID = sessionID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.status = status;
        }
        // accessor methods 
        public int GetSessionID() {
            return sessionID;
        }
        public void SetSessionID(int sessionID) {
            this.sessionID = sessionID;
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
        public DateTime GetTrainingDate() {
            return trainingDate;
        }
        public void SetTrainingDate (DateTime trainingDate) {
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
        public string GetStatus() {
            return status;
        }
        public void SetStatus(string status) {
            this.status = status;
        }
        public override string ToString()
        {
            return $"The session is {sessionID}, the customer's name and email is {customerName}, {customerEmail}, the training date is {trainingDate}, and the trainer name and status is {trainerName} & {status}. ";
        }
    }

}