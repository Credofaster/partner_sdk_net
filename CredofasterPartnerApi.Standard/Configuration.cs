using System.Collections.Generic;
using System.Text;
using CredofasterPartnerApi.Standard.Utilities;
using CredofasterPartnerApi.Standard.Models;
namespace CredofasterPartnerApi.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            //Live Environment
            PRODUCTION,
            //For Test Purpose
            SANDBOX,
            //Development
            DEVELOPMENT,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
            MY_CALLBACK_ENDPOINT,
        }

        //The current environment being used
        public static Environments Environment = Environments.SANDBOX;

        //Assigned APIKey
        //TODO: Replace the ApiKey with an appropriate value
        public static string ApiKey = "XXXX-XXXX-XXXX-XXXX";

        //Assigned ClientId
        //TODO: Replace the ClientId with an appropriate value
        public static string ClientId = "ABCDEDFG1234";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://api.partner.credofaster.co.ke" },
                        { Servers.MY_CALLBACK_ENDPOINT,"https://posthere.io/dfd0-4d32-8ad9" },
                    }
                },
                { 
                    Environments.SANDBOX,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://api-test.partner.credofaster.co.ke" },
                        { Servers.MY_CALLBACK_ENDPOINT,"https://posthere.io/dfd0-4d32-8ad9" },
                    }
                },
                { 
                    Environments.DEVELOPMENT,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://partner.credofaster.co.ke/crm_api/api/" },
                        { Servers.MY_CALLBACK_ENDPOINT,"https://partner.credofaster.co.ke/crm_api/api/" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}