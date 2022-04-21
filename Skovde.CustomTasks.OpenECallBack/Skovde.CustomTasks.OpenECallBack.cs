using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using OpenECallBack;

#pragma warning disable 1591

namespace Skovde.CustomTasks.OpenECallBack
{
    public static class OpenE
    {
        /// <summary>
        /// This task writes a message to an OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>A string</returns>
        public static string WriteMessageToOpenE([PropertyTab] AddOpenEMessageParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.addMessageAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.Message, parameters.Principal);
            return response.Result.ToString();
        }
        /// <summary>
        /// This task writes an internal message to an OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>A string</returns>
        public static string WriteInternalMessageToOpenE([PropertyTab] AddOpenEMessageParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.addInternalMessageAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.Message, parameters.Principal);
            return response.Result.ToString();
        }

        /// <summary>
        /// Sets the specified status to an OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>Task result</returns>
        public static Task<int> SetStatusOnOpenETicket([PropertyTab] SetStatusParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.setStatusAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.StatusID, parameters.Status, parameters.Principal);
            return response;
        }
        /// <summary>
        /// Gets the managers of a specified OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>getManagersResponse object</returns>
        public static getManagersResponse GetOpenEManagers([PropertyTab] GetManagersParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.getManagersAsync(parameters.GetManagers);
            return response.Result;
        }
        /// <summary>
        /// Set the managers of a specified OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>getManagersResponse object</returns>
        public static setManagersResponse SetOpenEManagers([PropertyTab] SetManagersParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.setManagersAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.Managers, parameters.ManagerGroups);
            return response.Result;
        }
        /// <summary>
        /// Add an event to an OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>Task result</returns>
        public static Task<int> AddEventToOpenE([PropertyTab] AddEventParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.addEventAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.DateTime, parameters.Message, parameters.Principal);
            return response;
        }
        /// <summary>
        /// Deletes an OpenE ticket.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>Task result</returns>
        public static Task DeleteOpenEInstance([PropertyTab] DeleteOpenEInstanceParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.deleteInstanceAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.LogMessage);
            return response;
        }
        /// <summary>
        /// Sets an OpenE attribute.
        /// Documentation: TO BE ADDED
        /// </summary>
        /// <returns>Task result</returns>
        public static Task SetOpenEAttribute([PropertyTab] SetOpenEAttributeParameters parameters, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var client = OpenEClient.GetOpenECallBackClient(options);
            var response = client.setAttributeAsync(parameters.FlowInstanceID, parameters.ExternalID, parameters.Name, parameters.Value);
            return response;
        }
    }
}
