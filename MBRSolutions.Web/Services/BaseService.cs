using MBRSolutions.Web.HelperClass;
using MBRSolutions.Web.Models;
using MBRSolutions.Web.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;

namespace MBRSolutions.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDTO responseModel { get; set; }
        public IHttpClientFactory _httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDTO();
            _httpClient = httpClient;
        }


        public async Task<T> SendAsync<T>(APIRequest request)
        {
            try
            {
                var client = _httpClient.CreateClient("mbrAPI");

                using HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(request.Url);

                client.DefaultRequestHeaders.Clear();

                if (request.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(request.Data),
                        Encoding.UTF8, "application/json");
                }

                if(!string.IsNullOrEmpty(request.AccessToken)) client.DefaultRequestHeaders.Authorization=new AuthenticationHeaderValue("Bearer",request.AccessToken);

                //using HttpResponseMessage apiResponse = null;

                message.Method = MsgRequestMethod(request.APIType);

                HttpResponseMessage apiResponse = null;

                apiResponse= await client.SendAsync(message);

                if (apiResponse.IsSuccessStatusCode)
                {
                    var apiContent = await apiResponse.Content.ReadAsStringAsync();
                    var apiResponseDTO = JsonConvert.DeserializeObject<T>(apiContent);
                    
                    return apiResponseDTO;
                }
                else
                {
                    ResponseDTO dto = new()
                    {
                        IsSuccess = false,
                        DisplayMessage = apiResponse.Content.ToString(),
                        ErrorMessages = new List<string> { apiResponse.StatusCode.ToString() }
                    };

                    var res = JsonConvert.SerializeObject(dto);
                    var apiResponseDTO = JsonConvert.DeserializeObject<T>(res);

                    return apiResponseDTO;
                }

            }
            catch (Exception ex)
            {
                ResponseDTO dto = new()
                {
                    IsSuccess = false,
                    DisplayMessage = ex.Message,
                    ErrorMessages = new List<string> { ex.Message.ToString() }
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDTO = JsonConvert.DeserializeObject<T>(res);

                return apiResponseDTO;
            }
        }

        public static HttpMethod MsgRequestMethod(APIType _apitype) =>

                          _apitype switch
                          {
                              APIType.POST => HttpMethod.Post,
                              APIType.PUT => HttpMethod.Put,
                              APIType.DELETE => HttpMethod.Delete,
                              _ => HttpMethod.Get
                          };



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
