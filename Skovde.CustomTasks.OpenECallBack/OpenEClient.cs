using OpenECallBack;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
#pragma warning disable 1591

namespace Skovde.CustomTasks.OpenECallBack
{
    public static class OpenEClient
    {
        public static IntegrationCallbackClient Client { get; set; }

        public static IntegrationCallbackClient GetOpenECallBackClient(Options options)
        {
            var endpoint = IntegrationCallbackClient.EndpointConfiguration.IntegrationCallbackPort;
            Client = new IntegrationCallbackClient(endpoint, options.RemoteAddress);
            Client.ClientCredentials.UserName.UserName = options.UserName;
            Client.ClientCredentials.UserName.Password = options.Password;
            OperationContextScope scope = new OperationContextScope(Client.InnerChannel);
            var httpRequestProperty = new HttpRequestMessageProperty();
            httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
            Convert.ToBase64String(Encoding.ASCII.GetBytes(Client.ClientCredentials.UserName.UserName + ":" +
            Client.ClientCredentials.UserName.Password));
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
            return Client;
        }
    }
}
