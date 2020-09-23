using System.Net;
using RestSharp;

namespace Adafy.Harvest.Netstandard
{
    internal static class Extensions
    {
        internal static long? ParseNullableLong(this string input)
        {
            long output;

            if (long.TryParse(input, out output))
            {
                return output;
            }

            return null;
        }

        internal static string ToYesNo(this bool input)
        {
            return input ? "yes" : "no";
        }

        internal static void ThrowIfBadRequest(this IRestResponse response)
        {
            if ((int) response.StatusCode >= 400)
            {
                throw new HarvestException(response);
            }
        }

        internal static bool IsSuccessfulDelete(this IRestResponse response)
        {
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
