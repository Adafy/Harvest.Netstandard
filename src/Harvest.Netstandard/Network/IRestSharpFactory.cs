using RestSharp;

namespace Adafy.Harvest.Netstandard.Network
{
    public interface IRestSharpFactory
    {
        IRestClient GetWebClient(string baseUrl, string userAgent, string username, string password);

        IRestClient GetWebClient(string baseUrl, string userAgent, string accessToken);

        IRestClient GetWebClient(string baseUrl, string userAgent);
    }
}
