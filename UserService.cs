using System;
using System.Threading.Tasks;
using RestSharp;

namespace RandomContact
{
    public class UserService
    {
        
        private RestClient Client;
        private string BaseUrl = "https://randomuser.me/api/";

        public UserService()
        {
            this.Client = new RestClient(this.BaseUrl);
        }

        public async Task<Result[]> GetUserProfiles()
        {
            var request = new RestRequest("", DataFormat.Json).AddParameter("results",50);
            var response = await Client.ExecuteAsync(request);
            var userModel = UserModel.FromJson(response.Content);
            return userModel.Results;
        }
    }
}
