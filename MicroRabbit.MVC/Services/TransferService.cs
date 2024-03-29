﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _appClient;

        public TransferService(HttpClient apiClient)
        {
            _appClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO),
                                                    System.Text.Encoding.UTF8, "application/json");

            var response = await _appClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
