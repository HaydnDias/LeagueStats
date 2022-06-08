namespace LeagueStats.Core
open System
open System.Net.Http
open SwaggerProvider
module LeagueGameApi =
    let [<Literal>] LeagueGameSchema = "LeagueGameClient.v1.Swagger_v2.json"
    type LeagueGame = OpenApiClientProvider<LeagueGameSchema>
    let baseAddress = Uri("https://127.0.0.1:2999/")
    let handler = new HttpClientHandler (UseCookies = false)
    handler.ServerCertificateCustomValidationCallback <- fun _ _ _ _ -> true
    let httpClient = new HttpClient(handler, true, BaseAddress=baseAddress)
    let leagueGameClient = LeagueGame.Client(httpClient)
    
    let getActivePlayerName =
            
            async {            
                let summonerName = leagueGameClient.GetLiveclientdataActiveplayername() |> Async.AwaitTask |> Async.RunSynchronously
                return summonerName 
            }
            
                        
                               
                               