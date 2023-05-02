namespace mis_221_pa_5_sncraven
{
    public class Listing
    {
        // instance variables 
        private int listingID;
        private string trainerName;
        private string sessionType;
        private DateOnly dateOfSession;
        private TimeSpan timeOfSession;
        private decimal costOfSession;
        private bool status;
        private bool deleted;
    
        static private int count;
        static private int max;

        // no arg constructor
        public Listing()
        {

        }

        // arg constructor
        public Listing(int listingID, string trainerName, string sessionType, DateOnly dateOfSession, TimeSpan timeOfSession, decimal costOfSession) {
            this.listingID = listingID;
            this.trainerName = trainerName; 
            this.sessionType = sessionType;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.status = true;
            this.deleted = false;
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
        public string GetSessionType()
        {
            return sessionType;
        }
        public void SetSessionType(string sessionType)
        {
            this.sessionType = sessionType;
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
        public decimal GetCostOfSession() {
            return costOfSession;
        }
        public void SetCostOfSession(decimal costOfSession){
            this.costOfSession = costOfSession;
        }
        public bool GetStatus()
        {
            return status; 
        }
        public void SetStatus(bool status) {
            this.status = true;
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
            Listing.count = count;
        }
        static public void IncCount() {
            Listing.count++;
        }
        static public int GetMax() 
        {
            return max;
        }
        static public void Setmax(int max)
        {
            Listing.max = max;
        }
        static public void IncMax()
        {
            Listing.max++;
        }
        // mutator methods
       
        
        // Tostring method 
        public override string ToString(){
            return $"The Listing ID is {listingID}, the trainer's name is {trainerName}, the session type is {sessionType}, the date of the session is {dateOfSession}, the time of the session is {timeOfSession}, and the cost of the session is {costOfSession}";
               
        }
        public string ToFile()
        {
            return $"{listingID}#{trainerName}#{sessionType}#{dateOfSession}#{timeOfSession}#{costOfSession}"; 
        }
    }


    
}