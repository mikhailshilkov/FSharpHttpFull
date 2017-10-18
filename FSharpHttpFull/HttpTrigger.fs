namespace FSharpHttpFull

open Microsoft.Azure.WebJobs.Host
open System.Net.Http
open System.Net
open Microsoft.Azure.WebJobs

module HttpTrigger =

  [<FunctionName("HttpTrigger")>]
  let Run([<HttpTrigger>] req: HttpRequestMessage, log: TraceWriter) =
    log.Info("F# HTTP trigger function processed a request.")

    req.CreateResponse(HttpStatusCode.OK, "Hi there!")