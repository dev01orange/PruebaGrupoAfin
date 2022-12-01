using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaGA_API.Models;

namespace PruebaGA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        [HttpGet]
        public async Task<BaseModel> GetPCountries()
        {
            BaseModel baseModel = new BaseModel();
            CountryModel country = new CountryModel();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://restcountries.com/v2/all");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        List<CountryModel> countryModel = JsonConvert.DeserializeObject<List<CountryModel>>(result);

                        baseModel = new BaseModel
                        {
                            status = "success",
                            data = countryModel,
                            message = ""

                        };
                    }
                    else
                    {
                        baseModel = new BaseModel
                        {
                            status = "failed",
                            data = { },
                            message = ""

                        };
                    }

                }
            }
            catch (Exception ex)
            {
                baseModel = new BaseModel
                {
                    status = "failed",
                    data = { },
                    message = ex.Message

                };
            }
            return baseModel;

        }

        [Route("name/{countryName}")]
        public async Task<BaseModel> GetCountryByName(string countryName)
        {
            BaseModel baseModel = new BaseModel();
            CountryModel country = new CountryModel();

            try
            {
                using (HttpClient client = new HttpClient())
                {


                    if (countryName != string.Empty)
                    {


                        HttpResponseMessage response = await client.GetAsync($"https://restcountries.com/v2/name/{countryName}");

                        if (response.IsSuccessStatusCode)
                        {
                            var result = await response.Content.ReadAsStringAsync();
                           List<CountryModel> countryModel = JsonConvert.DeserializeObject<List<CountryModel>>(result);


                            baseModel = new BaseModel
                            {
                                status = "success",
                                data = countryModel,
                                message = ""

                            };

                        }
                        else
                        {
                            baseModel = new BaseModel
                            {
                                status = "failed",
                                data = { },
                                message = ""

                            };
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                baseModel = new BaseModel
                {
                    status = "failed",
                    data = { },
                    message = ex.Message

                };
            }
            return baseModel;

        }

        [Route("code/{Region}")]
        public async Task<BaseModel> GetPaisesByContinentName(string Region)
        {
            BaseModel baseModel = new BaseModel();
            CountryModel responseModel = new CountryModel();

            try
            {
                using (HttpClient client = new HttpClient())
                {


                    if (Region != String.Empty)
                    {


                        HttpResponseMessage response = await client.GetAsync($"https://restcountries.com/v2/region/{Region}");

                        if (response.IsSuccessStatusCode)
                        {
                            var result = await response.Content.ReadAsStringAsync();
                            List<CountryModel> countryModel = JsonConvert.DeserializeObject<List<CountryModel>>(result);


                            baseModel = new BaseModel
                            {
                                status = "success",
                                data = countryModel,
                                message = ""

                            };
                        }
                        else
                        {
                            baseModel = new BaseModel
                            {
                                status = "failed",
                                data = { },
                                message = ""

                            };
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                baseModel = new BaseModel
                {
                    status = "failed",
                    data = { },
                    message = ex.Message

                };
            }
            return baseModel;

        }

    }
}
