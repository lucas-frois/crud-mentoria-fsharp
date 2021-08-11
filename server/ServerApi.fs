module Server

open Microsoft.Extensions.Logging
open Microsoft.Extensions.Configuration
open Shared

/// An implementation of the Shared IServerApi protocol.
/// Can require ASP.NET injected dependencies in the constructor and uses the Build() function to return value of `IServerApi`.
type ServerApi(logger: ILogger<ServerApi>, config: IConfiguration) =
    member this.Note() =
        async {
            logger.LogInformation("Executing {Function}", "counter")
            do! Async.Sleep 1000
            return {
              id = 1
              date = ""
              message = ""
            }
        }
       member this.Mentee() =
        async {
            logger.LogInformation("Executing {Function}", "counter")
            do! Async.Sleep 1000
            return {
              id = 1 
              name =  ""
              city =  ""
              twitter =  ""
              contact =  ""
              college =  ""
              work = ""
              knowledges =  ""
              goals = ""
            }
        }

    member this.Build() : IServerApi =
        {
            Note = this.Note
            Mentee = this.Mentee
        }