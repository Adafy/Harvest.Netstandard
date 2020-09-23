using System;
using Adafy.Harvest.Netstandard.Models;
using RestSharp;
using RestSharp.Deserializers;

namespace Adafy.Harvest.Netstandard
{
    public class HarvestException : Exception
    {
        public HarvestException(IRestResponse response)
        {
            Response = response;

            try
            {
                IDeserializer deserializer = new XmlDeserializer();
                Result = deserializer.Deserialize<ErrorResult>(response);
            }
            catch
            {
                // could not deserialize the response... eat it
            }
        }

        public IRestResponse Response { get; }

        public ErrorResult Result { get; }

        public override string Message
        {
            get
            {
                if (Result != null)
                {
                    return Result.Message;
                }

                return "An error occurred, but could not deserialize the error response";
            }
        }
    }
}
