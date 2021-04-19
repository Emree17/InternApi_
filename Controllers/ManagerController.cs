using InternAPI.Models;
using InternAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternAPI.Controllers
{
    [Route("api/manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerRepository _managerRepo;

        public ManagerController(IManagerRepository managerRepo)
        {
            _managerRepo = managerRepo;
        }



      
        [HttpGet]
        public List<Sirket> Get()
        {
            return _managerRepo.GetAllŞirkets();
            
        }



        
        [HttpGet("{id}")]
        public Sirket Get(int id)
        {
            return _managerRepo.GetSirketById(id);
        }




        
        
        [HttpPost]
        public Sirket Post([FromBody]Sirket sirket)
        {
            return _managerRepo.CreateSirket(sirket);
               
        }

        



        [HttpPut]
        public Sirket Put([FromBody]Sirket sirket)
        {
            return _managerRepo.UpdateSirket(sirket);

        }
        



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _managerRepo.DeleteSirket(id);
        }
    }
}
