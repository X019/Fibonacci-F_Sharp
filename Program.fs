open System
open System.Collections.Generic
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting

[<EntryPoint>]
let main (args: string[]) =
    let fibSeq: ResizeArray<int> = ResizeArray<int>(); //make a dumb array
    fibSeq.Add(0);  fibSeq.Add(1); //add the first two elements to the array
    
    let fibLength: int = 10;
    for i=0 to fibLength do
        fibSeq.Add(fibSeq[i] + fibSeq[i + 1]) //fibonacci addition thing
    
    for i: int in fibSeq do
        printf "%d, " i //print

    0 // Exit code

