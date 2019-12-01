# Handlebars template renderer extension for RedHttpServer
### Handlebars renderer extension for RedHttpServer using [Handlebars.Net](https://github.com/rexm/Handlebars.Net)
[![GitHub](https://img.shields.io/github/license/redhttp/red.handlebarsrenderer)](https://github.com/RedHttp/Red.HandlebarsRenderer/blob/master/LICENSE.md)
[![Nuget](https://img.shields.io/nuget/v/red.handlebarsrenderer)](https://www.nuget.org/packages/red.handlebarsrenderer/)
[![Nuget](https://img.shields.io/nuget/dt/red.handlebarsrenderer)](https://www.nuget.org/packages/red.handlebarsrenderer/)
![Dependent repos (via libraries.io)](https://img.shields.io/librariesio/dependent-repos/nuget/red.handlebarsrenderer)

### Usage
After installing and referencing this library, the `Red.Response` has the extension method `RenderTemplate(filePath, renderParams, ..)` 

`RenderTemplate(filePath, renderParams, ..)` takes the path of a Handlebars template file and sends the html, rendered using the render parameter object, as response.
