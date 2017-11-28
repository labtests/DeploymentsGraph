using SlackDeploy.Graph;
using Swashbuckle.Application;
using Swashbuckle.OData;
using System.Web;
using System.Web.Http;


[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]
namespace SlackDeploy.Graph
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SlackDeploy.Graph").Contact(contactBuilder => contactBuilder
                        .Url("http://slackdeploygraph.azurewebsites.net/v1/swagger"));                       
                        c.CustomProvider(defaultProvider => new ODataSwaggerProvider(defaultProvider, c));
                    })
                .EnableSwaggerUi(c =>{});
        }
    }
}
