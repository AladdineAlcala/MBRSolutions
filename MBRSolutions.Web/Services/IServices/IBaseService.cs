using MBRSolutions.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MBRSolutions.Web.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        public ResponseDTO responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest request);
    }
}
