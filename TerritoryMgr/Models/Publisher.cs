using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.Security.Policy;

namespace TerritoryMgr.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// 
        /// </summary>
        public Publisher()
        {
            PublisherType = PublisherType.Publisher;
        }

        /// <summary>
        /// Unique Id for this Publisher (system assigned)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Service Group this publisher is assigned to
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// First name of the Publisher
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the Publisher
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Best contact phone number of the Publisher (Mobile preferred)
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Email address of the Publisher
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Type of Publisher
        /// </summary>
        public PublisherType PublisherType { get; set; }

        /// <summary>
        /// Full name of the Publisher
        /// </summary>
        [Computed]
        public string FullName => FirstName + " " + LastName;

    }

    /// <summary>
    /// 
    /// </summary>
    public enum PublisherType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(PublisherTypeDescription.Publisher)]
        Publisher = 0,
        /// <summary>
        /// 
        /// </summary>
        //[Description(PublisherTypeDescription.Servant)]
        Servant = 1,
        /// <summary>
        /// 
        /// </summary>
        //[Description(PublisherTypeDescription.Elder)]
        Elder = 2
    }

    /// <summary>
    /// Description of Publisher types (Spanish)
    /// </summary>
    public  class PublisherTypeDescription
    {
        public static string Publisher = Resources.LocalizedText.Hello;
        public static readonly string Servant = Resources.Servant.ToString();
        public static readonly string Elder = Resources.Elder.ToString();
    }
}

namespace Resources
{
    public enum Servant
    {
    }
}