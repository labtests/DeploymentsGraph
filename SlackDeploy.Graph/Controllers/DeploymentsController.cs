using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SlackDeploy.Graph.Models;

namespace DriveTrack.Graph.Controllers
{
    public class DeploymentsController : ApiController
    {
        //private DriveTrackDB db = new DriveTrackDB();

        //// GET: api/Deployments
        //public IQueryable<Deployment> Getdeployments()
        //{            
        //    return db.deployments;
        //}

        //// GET: api/Deployments/2139055893
        //[ResponseType(typeof(Deployment))]
        //public async Task<IHttpActionResult> GetDeployment(int id)
        //{
        //    Deployment deployment = await db.deployments.FindAsync(id);
        //    if (deployment == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(deployment);
        //}

        //// GET: api/Deployments/callista
        //[ResponseType(typeof(Deployment))]
        //public IQueryable<Deployment> GetDeployment(string engineer)
        //{
        //    var deployments = db.deployments.Where(x=>x.engineer.Equals(engineer,StringComparison.CurrentCultureIgnoreCase));           
        //    return deployments;
        //}

        //// PUT: api/Deployments/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutDeployment(int id, Deployment deployment)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != deployment.id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(deployment).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DeploymentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Deployments
        //[ResponseType(typeof(Deployment))]
        //public async Task<IHttpActionResult> PostDeployment(Deployment deployment)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.deployments.Add(deployment);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = deployment.id }, deployment);
        //}

        //// DELETE: api/Deployments/5
        //[ResponseType(typeof(Deployment))]
        //public async Task<IHttpActionResult> DeleteDeployment(int id)
        //{
        //    Deployment deployment = await db.deployments.FindAsync(id);
        //    if (deployment == null)
        //    {
        //        return NotFound();
        //    }

        //    db.deployments.Remove(deployment);
        //    await db.SaveChangesAsync();

        //    return Ok(deployment);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool DeploymentExists(int id)
        //{
        //    return db.deployments.Count(e => e.id == id) > 0;
        //}
    }
}