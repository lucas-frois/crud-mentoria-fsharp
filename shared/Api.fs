module Shared

/// Defines how routes are generated on server and mapped from client
let routerPaths typeName method = sprintf "/api/%s" method

type Note = { 
  id: int
  date: string
  message: string
}

type Mentee = {
  id: int 
  name: string
  city: string
  twitter: string
  contact: string
  college: string
  work: string
  knowledges: string
  goals: string
}
/// A type that specifies the communication protocol between client and server
/// to learn more, read the docs at https://zaid-ajaj.github.io/Fable.Remoting/src/basics.html
type IServerApi = {
  Note: unit -> Async<Note>
  Mentee: unit -> Async<Mentee>
}