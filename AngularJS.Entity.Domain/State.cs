namespace AngularJS.Entity.Domain
{
    public class State
    {
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public virtual Country  Country{get;set;}
    }
}