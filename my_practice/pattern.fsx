open System

let Three = 3

let filter123 x =
    match x with 
    | 1 | 2 | 3 -> printfn "found 1, 2, or 3"
    | var1 -> printfn "found %d" var1

filter123 3
filter123 6

let rec printList items = 
    match items with 
    | h :: t -> printfn "%d" h; printList t 
    | [] -> printfn " "

printList [6..10]

try
    printfn "Diff = %i" (42/1)
    failwith "Something else"
with 
| :? DivideByZeroException as x -> printfn "fail: %s" x.Message
| :? TimeoutException -> printfn "fail! took too long"
| z -> printfn "another fail with %s" z.Message


let (|Seconds|) (dt : DateTime) =
    dt.Second

let getSecs (Seconds seconds) =
    printfn "seconds %d" seconds

getSecs DateTime.Now

let (|Low|Medium|High|) (x:int) =
    if x < 10 then
        Low 0.7
    elif x < 50 then
        Medium 1.1
    else
        High 3.0

match 52 with 
| Low x -> printfn "too low (%f)" x
| Medium x -> printfn "seems ok (%f)" x
| High x -> printfn "too high (%f)" x

