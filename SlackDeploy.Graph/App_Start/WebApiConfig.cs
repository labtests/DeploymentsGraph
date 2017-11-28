using System.Web.Http;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData.Batch;
using System.Web.OData.Extensions;
using System.Web.Http.ExceptionHandling;
using Microsoft.ApplicationInsights;
using Microsoft.Restier.Publishers.OData;
using SlackDeploy.Graph.Models;

namespace SlackDeploy.Graph
{
    public static class WebApiConfig
    {
        public async static void Register(HttpConfiguration config)
        {
            config.EnableCaseInsensitive(caseInsensitive: true);
            config.EnableUnqualifiedNameCall(true);

            await config.MapRestierRoute<EntityFrameworkApi<DriveTrackDB>>("DriveTrackGraph", "v1", new RestierBatchHandler(GlobalConfiguration.DefaultServer));

            config.Services.Add(typeof(IExceptionLogger), new AiExceptionLogger());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "command/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });            
        }
    }

    public class AiExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            if (context != null && context.Exception != null)
            {
                var ai = new TelemetryClient();
                ai.TrackException(context.Exception);
            }
            base.Log(context);
        }
    }
}
