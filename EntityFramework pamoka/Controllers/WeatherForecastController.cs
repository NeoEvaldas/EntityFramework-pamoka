using EntityFramework_pamoka.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_pamoka.Controllers
{
    [ApiController]
    [Route("/")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly PavyzdinisDbContext _dbContext;

        public WeatherForecastController(PavyzdinisDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/daiktai")]
        public List<Daiktas> VisiDaiktai()
        {
            return _dbContext.Daiktai.Where(x => x.Pavadinimas != "kazkas").ToList();
        }

        [HttpGet]
        [Route("/automobiliai")]
        public List<Automobilis> VisiAutomobiliai()
        {
            return _dbContext.Automobiliai.Where(x => x.Marke != "kazkas").ToList();
        } 

        [HttpGet]
        [Route("Daiktai/daiktoId")]
        public ActionResult<Daiktas?> GautiDaikta(int daiktoId)
        {
            var daiktas =  _dbContext.Daiktai.Where(x => x.Id == daiktoId).FirstOrDefault();
            if (daiktas == null)
            {
                return NotFound();
            }
            return daiktas;
        }



        [HttpGet]
        [Route("/savininkai")]
        public List<Savininkas> VisiSavininkai()
        {
            return _dbContext.Savininkai.Where(x => x.Vardas != "kazkas").ToList();
        }

        [HttpGet]
        [Route("Savinikai/SavininkoId")]
        public ActionResult<Savininkas?> GautiSavininka(int SavininkoIdId)
        {
            var savininkas = _dbContext.Savininkai.Where(x => x.Id == SavininkoIdId).FirstOrDefault();
            if (savininkas == null)
            {
                return NotFound();
            }
            return savininkas;
        }
        

        [HttpGet]
        [Route("/pridetiDaikta/{savininkoId}")]
        public void PridetiDaikta(int? savininkoId)
        {
            var savininkas = _dbContext.Savininkai.Where(x => x.Id == savininkoId).FirstOrDefault();
            _dbContext.Daiktai.Add(new Daiktas() { Pavadinimas = "Telefonas", SavininkasId = savininkas != null ? savininkas.Id : 1 });
            _dbContext.SaveChanges();
        }

        [HttpGet]
        [Route("/pridetiSavininka")]
        public void PridetiSavininka()
        {
            _dbContext.Savininkai.Add(new Savininkas() { Vardas = "Jonas" });
            _dbContext.SaveChanges();
        }
       [HttpDelete]
       [Route("/daiktas/{daiktoId}")]

       public void IstrintiDaikta(int? daiktoId)
        {
            var daiktas = _dbContext.Daiktai.Where(x=> x.Id == daiktoId).FirstOrDefault();
           
            if (daiktas != null)
            {

                _dbContext.Daiktai.Remove(daiktas);
                _dbContext.SaveChanges();
            }

        }
        [HttpDelete]
        [Route("/savininkas/savininkoId")]
        public void IstrintiSavinika(int? savininkoId)
        {
            var savininkas = _dbContext.Savininkai.Where(x=> x.Id == savininkoId).FirstOrDefault();
            if (savininkas != null)
            {

                _dbContext.Savininkai.Remove(savininkas);
                _dbContext.SaveChanges();
            }
        }

        [HttpPost]
        [Route("pridetiDaikta")]

        public void pridetiDaiktaPost([FromBody] DaiktasJSON daiktas)
        {
            var savininkas = _dbContext.Savininkai.Where(x=>x.Id == daiktas.SavininkasId).FirstOrDefault();
            _dbContext.Daiktai.Add(new Daiktas()
            {
                Pavadinimas = daiktas.Pavadinimas,
                SavininkasId   = daiktas.SavininkasId,
            });
            _dbContext.SaveChanges();
        }
        
    }
}