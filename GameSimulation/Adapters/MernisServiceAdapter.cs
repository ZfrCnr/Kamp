using System;
using System.Collections.Generic;
using System.Text;
using GameSimulation.Abstract;
using GameSimulation.Entities;
using MernisServiceReference;

namespace GameSimulation.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName,
                    user.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
