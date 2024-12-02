using Jaaqcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jaaqcore.Controllers
{
    [ApiController]
    [Route("Client")]
    public class ClienteController : ControllerBase
    {
        //Localhost/client/ClientList
        [HttpGet]
        [Route("ClientList")]
        public dynamic GetClients()
        {
            //
            List<Client> Clients = new List<Client>
            {
                 new Jaaqcore.Models.Client
                 {

                    Id = "1",
                    Name = "Jorge",
                    Email = "jorge@gmail.com",
                    Edad = "30"

                  },
                 new Jaaqcore.Models.Client
                  {

                    Id = "2",
                    Name = "Jose",
                    Email = "Jose@gmail.com",
                    Edad = "29"

                  },
                 new Jaaqcore.Models.Client
                  {

                    Id = "3",
                    Name = "Omar",
                    Email = "Omar@gmail.com",
                    Edad = "28"
                  },
                    new Jaaqcore.Models.Client
                  {

                    Id = "4",
                    Name = "Diana",
                    Email = "Diana@gmail.com",
                    Edad = "30"
                  }
};

            return Clients;
        }

        //[HttpPost]
        //[Route("AddClient")]
        //public dynamic AddCliente()
        //{

        //}
    }
}
