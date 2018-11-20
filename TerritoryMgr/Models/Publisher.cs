using Dapper.Contrib.Extensions;

namespace TerritoryMgr.Models
{
    public class Publisher
    {
        public Publisher()
        {
            IsElder = false;
            IsPioneer = false;
            IsGroupOverseer = false;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public bool IsPioneer { get; set; }
        public bool IsElder { get; set; }
        public bool IsGroupOverseer { get; set; }

        [Computed]
        public string FullName => FirstName + " " + LastName;

    }
}