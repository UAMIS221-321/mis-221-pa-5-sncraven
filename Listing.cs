namespace mis_221_pa_5_sncraven
{
    public class Listing
    {
        // instance variables 
        private int listingID;
        private string trainerName;
        private DateOnly dateOfSession;
        private TimeSpan timeOfSession;
        private int costOfSession;
        private bool status;
        private bool isDeleted;
        private bool listingsAreTaken;
        static private int count;

        // no arg constructor
        public Listing()
        {

        }

        // arg constructor
        public Listing(int listingID, string trainerName, DateOnly dateOfSession, TimeSpan timeOfSession, int costOfSession, bool listingsAreTaken, bool status, bool isDeleted) {
            this.listingID = listingID;
            this.trainerName = trainerName; 
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.listingsAreTaken = true;
            this.status = true;
            this.isDeleted = false;
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
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public DateOnly GetDateOfSession() {
            return dateOfSession;
        }
        public void SetDateOfSession(DateOnly dateOfSession) {
            this.dateOfSession = dateOfSession;
        }
        public TimeSpan GetTimeOfSession() {
            return timeOfSession;
        }
        public void SetTimeOfSession(TimeSpan timeOfSession) {
            this.timeOfSession = timeOfSession;
        }
        public int GetCostOfSession() {
            return costOfSession;
        }
        public void SetCostOfSession(int costOfSession){
            this.costOfSession = costOfSession;
        }
        public void Status() {
            status = !status;
        }
        public void IsDeleted()
        {
            isDeleted = !isDeleted;
        }
        static public int GetCount() {
            return count;
        }
        static public void SetCount(int count) {
            Listing.count = count;
        }
        static public void IncCount() {
            Listing.count++;
        }
        // mutator methods
        public void ListingsAreTaken() {
            listingsAreTaken = !listingsAreTaken;
        }
        // Tostring method 
        public override string ToString(){

               return $"{listingID}#{trainerName}#{dateOfSession}#{timeOfSession}#{costOfSession}";    
        }
    }


    
}