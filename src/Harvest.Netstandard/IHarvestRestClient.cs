using Adafy.Harvest.Netstandard.Models.Interfaces;
using RestSharp;

namespace Adafy.Harvest.Netstandard
{
    public partial interface IHarvestRestClient
    {
        string BaseUrl { get; }

        string DateFormat { get; set; }

        T Execute<T>(IRestRequest request)
            where T : new();

        IRestResponse Execute(IRestRequest request);

        IOAuth RefreshToken(string refreshToken);
    }
}
