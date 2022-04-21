#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OpenECallBack;

namespace Skovde.CustomTasks.OpenECallBack
{
    /// <summary>
    /// Parameters class usually contains parameters that are required.
    /// </summary>
    ///
    public class AddOpenEMessageParameters
    {
        public IntegrationMessage Message { get; set; }
        public ExternalID ExternalID { get; set; }
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("FlowInstanceID to write message to")]
        public int FlowInstanceID { get; set; }
        public Principal Principal { get; set; }
    }

    public class GetManagersParameters
    {
        public getManagersRequest GetManagers { get; set; }
    }

    public class AddEventParameters
    {
        public int FlowInstanceID { get; set; }
        public ExternalID ExternalID { get; set; }
        public System.DateTime DateTime { get; set; }
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("Event message")]
        public string Message { get; set; }
        public Principal Principal { get; set; }
    }

    public class DeleteOpenEInstanceParameters
    {
        public int FlowInstanceID { get; set; }
        public ExternalID ExternalID { get; set; }
        public string LogMessage { get; set; }
    }

    public class SetOpenEAttributeParameters
    {
        public int FlowInstanceID { get; set; }
        public ExternalID ExternalID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SetManagersParameters
    {
        public int FlowInstanceID { get; set; }
        public ExternalID ExternalID { get; set; }
        public Principal[] Managers { get; set; }
        public PrincipalGroup[] ManagerGroups { get; set; }
    }

    public class SetStatusParameters
    {
        public string Status { get; set; }
        public int StatusID { get; set; }
        public ExternalID ExternalID { get; set; }
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("FlowInstanceID to write message to")]
        public int FlowInstanceID { get; set; }
        public Principal Principal { get; set; }
    }

    /// <summary>
    /// Takes input for OpenE details.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Username, password and URI to connect to OpenE.
        /// </summary>
        [DisplayFormat(DataFormatString = "Expression")]
        [DefaultValue("URI to OpenE CallBack")]
        public string RemoteAddress { get; set; }
        [DisplayFormat(DataFormatString = "Expression")]
        [DefaultValue("OpenE UserName")]
        public string UserName { get; set; }
        [DisplayFormat(DataFormatString = "Expression")]
        [DefaultValue("OpenE Password")]
        public string Password { get; set; }
    }
}
