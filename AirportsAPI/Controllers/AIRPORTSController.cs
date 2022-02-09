using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AirportsAPI.Models;

namespace AirportsAPI.Controllers
{
    public class AIRPORTSController : ApiController
    {
        private AVIATION_COSTARICAEntities1 db = new AVIATION_COSTARICAEntities1();

        // GET: api/AIRPORTS
        public IHttpActionResult GetAIRPORTS()
        {
            return Json(db.AIRPORTS.ToList());
        }

        // GET: api/AIRPORTS/5
        [ResponseType(typeof(AIRPORTS))]
        public IHttpActionResult GetAIRPORTS(int id)
        {
            AIRPORTS aIRPORTS = db.AIRPORTS.Find(id);
            if (aIRPORTS == null)
            {
                return NotFound();
            }

            return Json(aIRPORTS);
        }

    }
}