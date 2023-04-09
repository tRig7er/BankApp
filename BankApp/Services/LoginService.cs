using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var UserInfo = new UserInfo();
                    var client = new HttpClient();
                    string url = "hhtp://192.168.61.40:8099/api/UserInfoes/LoginUser/"+username+"/"+password;
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        UserInfo =await response.Content.ReadFromJsonAsync<UserInfo>();
                        return await Task.FromResult(UserInfo);
                    }
                    else 
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
