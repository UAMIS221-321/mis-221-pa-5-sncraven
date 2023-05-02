namespace mis_221_pa_5_sncraven
{
    public class Trainer
    {
        // instance variables 
        private int trainerID;
        private string trainerName;
        private string mailingAddress;

        private double trainerNumber;
        private string trainerEmailAddress;

        private bool deleted;
        // class variable 
        static private int count; // 1 count for the entire variable
        // no arg constructor 
        static private int max; 
        public Trainer() {

        }
        // arg constructor 
        public Trainer(string trainerName, int trainerID, string mailingAddress, double trainerNumber, string trainerEmailAddress)  
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerNumber = trainerNumber;
            this.trainerEmailAddress = trainerEmailAddress;
            this.deleted = false;
        }
        // accessor methods 
        public int GetTrainerID() {
            return trainerID;
        }
        public void SetTrainerID(int trainerID) {
            this.trainerID = trainerID;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public string GetMailingAddress() {
            return mailingAddress;
        }
        public void SetMailingAddress(string mailingAddress){
            this.mailingAddress = mailingAddress;
        }
        public double GetTrainerNumber()
        {
            return trainerNumber;
        }
        public void SetTrainerNumber(double trainerNumber)
        {
            this.trainerNumber = trainerNumber;
        }
        public string GetTrainerEmailAddres() {
            return trainerEmailAddress;
        }
        public void SetTrainerEmailAddress(string trainerEmailAddress) {
            this.trainerEmailAddress = trainerEmailAddress;
        }
        public bool GetDeleted()
        {
            return deleted;
        }
        public void SetDeleted(bool deleted)
        {
            this.deleted = false;
        }
        static public int GetCount() {
            return count;
        }
        static public void SetCount(int count) {
            Trainer.count = count;
        }

        static public void IncCount() {
            Trainer.count++;
        }
        static public int GetMax() 
        {
            return max;
        }
        static public void SetMax(int max)
        {
            Trainer.max = max;
        }
        static public void IncMax()
        {
            Trainer.max++;
        }
        // ToString method 
        public override string ToString() {

            return $"The name of the trainer is {trainerName}, their ID number is {trainerID}, their email address is {trainerEmailAddress}, their phone number is {trainerNumber}, and their mailing address is {mailingAddress}";
        }
        public string ToFile()
        {
            return $"{trainerName}#{trainerID}#{mailingAddress}#{trainerNumber}#{trainerEmailAddress}";
        }
        
    }
}