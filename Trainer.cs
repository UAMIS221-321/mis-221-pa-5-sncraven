namespace mis_221_pa_5_sncraven
{
    public class Trainer
    {
        // instance variables 
        private int trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;

        private bool isDeleted;
        // class variable 
        static private int count; // 1 count for the entire variable
        // no arg constructor 
        public Trainer() {

        }
        // arg constructor 
        public Trainer(int trainerID, string trainerName, string mailingAddress, string trainerEmailAddress)  {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
            this.isDeleted = false;
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
        public string GetTrainerEmailAddres() {
            return trainerEmailAddress;
        }
        public void SetTrainerEmailAddress(string trainerEmailAddress) {
            this.trainerEmailAddress = trainerEmailAddress;
        }
        public void IsDeleted()
        {
            isDeleted = !isDeleted;
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
        // ToString method 
        public override string ToString() {
            
            return $"#{trainerName}#{trainerID}#{trainerEmailAddress}#{mailingAddress}";
        }
        
    }
}