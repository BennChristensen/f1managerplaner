using F1Model.Interfaces;
using F1Model.Models;
using Infrastructure.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class JsonFileDriverProvider : IDriverProvider
    {
        private readonly JsonFileDriverProviderOptions _jsonFileOptions;

        public JsonFileDriverProvider(IOptions<JsonFileDriverProviderOptions> options)
        {
            this._jsonFileOptions = options.Value;
        }
        public async Task<IEnumerable<Driver>> GetDrivers()
        {
            using var driverFile = File.OpenRead(_jsonFileOptions.FilePath);
            return await JsonSerializer.DeserializeAsync<List<Driver>>(driverFile);
        }
    }
}
