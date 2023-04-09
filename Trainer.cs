namespace mis_221_pa_5_sncraven
{
    public class Trainer
    {
        // instance variables 
        private int trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;
        // no arg constructor 
        // public Trainer() {

        // }
        // arg constructor 
        public Trainer(int trainerID, string trainerName, string mailingAddress, string trainerEmailAddress)  {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
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
        // ToString method 
        public override string ToString() {
            return $"The trainer is {trainerName}, thier ID number is {trainerID},their email is {trainerEmailAddress}, their mailing address is {mailingAddress}.";
        }
        
    }
}