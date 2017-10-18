# Example of F# Azure Function using WebJobs attributes to auto-generate `function.json`

This kind of Azure Function in F#

``` fs
[<FunctionName("HttpTrigger")>]
let Run([<HttpTrigger>] req: HttpRequestMessage, log: TraceWriter) =
    log.Info("F# HTTP trigger function processed a request.")
    req.CreateResponse(HttpStatusCode.OK, "Hi there!")
```

is not supported by `Microsoft.NET.Sdk.Functions` directly (yet).
To make auto-generation of `function.json` work, I'm calling the tool
manually after each successful build.