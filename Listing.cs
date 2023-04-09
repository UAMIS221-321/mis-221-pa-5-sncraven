namespace mis_221_pa_5_sncraven
{
    public class Listing
    {
        // instance variables 
        private int listingID;
        private string trainerName;
        private DateTime dateOfSession;
        private TimeSpan timeOfSession;
        private decimal costOfSession;
        private bool listingsAreTaken;

        // arg constructor
        public Listing(int listingID, string trainerName, DateTime dateOfSession, TimeSpan timeOfSession, decimal costOfSession, bool listingsAreTaken) {
            this.listingID = listingID;
            this.trainerName = trainerName; 
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.listingsAreTaken = listingsAreTaken;
        }
        // accessor methods 
        public int GetListingID() {
            return listingID;
        }
        public void SetListingID(int listingID) {
            this.listingID = listingID;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public void SetTrainerName(string listingName) {
            this.trainerName = listingName;
        }
        public DateTime GetDateOfSession() {
            return dateOfSession;
        }
        public void SetDateOfSession(DateTime dateOfSession) {
            this.dateOfSession = dateOfSession;
        }
        public TimeSpan GetTimeOfSession() {
            return timeOfSession;
        }
        public void SetTimeOfSession(TimeSpan timeOfSession) {
            this.timeOfSession = timeOfSession;
        }
        public decimal GetCostOfSession() {
            return costOfSession;
        }
        public void SetCostOfSession(decimal costOfSession){
            this.costOfSession = costOfSession;
        }
        // mutator methods
        public void ListingsAreTaken() {
            listingsAreTaken = !listingsAreTaken;
        }
        // Tostring method 
        public override string ToString(){
            if(listingsAreTaken)
            {
                return $"there are no available sessions";
            } else {
               return $"The ID number is {listingID}, the trainer's name is {trainerName}, the session's date, time, and cost is {dateOfSession}, {timeOfSession}, and {costOfSession}";
            }
        }
    }


    
}