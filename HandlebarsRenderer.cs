using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Red.HandlebarsRenderer
{
    /// <summary>
    ///     Handlebars renderer extension using Handlebars.Net
    /// </summary>
    public static class HandlebarsRenderer
    {
        /// <summary>
        ///     Renders a Handlebars template file and sends it
        /// </summary>
        /// <param name="response">The instance of the response</param>
        /// <param name="filePath">The path of the Handlebars template file to be rendered</param>
        /// <param name="renderParams">The render parameter object which will be passed to the template renderer</param>
        /// <param name="cacheRenderers">Whether to cache renderers. Recommended</param>
        /// <param name="status">The status code for the response</param>
        public static Task RenderTemplate(this Response response, string filePath, object renderParams, bool cacheRenderers = true,
            HttpStatusCode status = HttpStatusCode.OK)
        {
            response.UnderlyingResponse.StatusCode = (int) status;
            response.UnderlyingResponse.ContentType = "text/html";
            var renderer = HandlebarsCache.Instance.GetRenderer(filePath, cacheRenderers);
            using (var writer = new StreamWriter(response.UnderlyingResponse.Body))
            {
                renderer(writer, renderParams);
            }

            response.Closed = true;
            return Task.CompletedTask;
        }
    }
}