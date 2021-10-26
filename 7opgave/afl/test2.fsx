type Position = int
type Board = char list
let rnd = System.Random ()

let create (n : uint ) : Board =
    let lst = ['a' .. 'y']
    lst.[0..((int (n) * int (n))-1)]

let board2Str (b : Board) : string = 
    List.toArray b |> System.String

let validRotation (b : Board) (p : Position) : bool =
    match p with
    | x1 when double p = double 1 + (sqrt (double (b.Length))) -> false
    | x2 when double p = double 1 + (double 2 * sqrt (double (b.Length))) -> false
    | x3 when double p = double 1 + (double 3 * sqrt (double (b.Length))) -> false
    | x4 when double p = double 1 + (double 4 * sqrt (double (b.Length))) -> false
    | x5 when double p > double 1 + ((double b.Length) - (double (sqrt (double b.Length)))) -> false
    | _ -> true

let rotate (b : Board) (p : Position) : Board =
    let (boardSize : int) = int(sqrt(double b.Length))
    if validRotation (b) (p) then
        b.[0..(p-1)] @ (b.[p + boardSize] :: (b.[p] :: (b.[(p+2) .. (p+boardSize-1)] @ (b.[p+boardSize+1] :: (b.[p+1] :: (b.[(p+boardSize+2)..])))))) 
    else b

let rec allowedRotation (b : Board) (p : Position) : Position =
        let (boardSize : int) = int(sqrt(double b.Length))
        if (validRotation (b) (p)) then p
        else (allowedRotation (b) (rnd.Next (boardSize)))

printf "%A " (allowedRotation (create 5u) (rnd.Next 25))
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printf "%A " (allowedRotation (create 5u) (rnd.Next 25))  
printfn "%A" (allowedRotation (create 5u) (rnd.Next 25))  


//let scramble (b : Board) (m : uint) : Board =
  //  let (boardSize : int) = int(sqrt(double b.Length))
    //let rec scrambler (b : Board) (p : Position) (m : uint) : Board =
      //  match m with
        //| 0u -> b
        //| _ -> (scrambler (rotate (b) (allowedRotation (b) (p))) (allowedRotation (b) (p)) (m-1u)) 
    //scrambler (b) (allowedRotation (b) (rnd.Next (boardSize))) (m)


let rec scramble2 (b : Board) (m : uint) : Board =
    let (boardSize : int) = int(sqrt(double b.Length))
    match m with
    | 0u -> (rotate (b) (allowedRotation (b) (rnd.Next (boardSize))))
    | _ -> (scramble2 (rotate (b) (allowedRotation (b) (rnd.Next (boardSize)))) (m-1u))

let solved (b : Board) : bool =
    let (boardSize : int) = int(sqrt(double b.Length))
    match b with
    | itsTrue when b = (create (uint(boardSize))) -> true
    | _ -> false

//printfn "%s" (board2Str (create 4u))
//printfn "%b" (validRotation (create 4u) (13))
//printfn "%b" (validRotation (create 4u) (12))
//printfn "%b" (validRotation (create 4u) (6))
//printfn "%b" (validRotation (create 5u) (25))
//printfn "%b" (validRotation (create 5u) (21))
//printfn "4x4 med a: %20A" (rotate (create 4u) (0))
//printfn "4x4 med d: %20A" (rotate (create 4u) (3))
//printfn "4x4 med j: %20A" (rotate (create 4u) (9))
//printfn "%20A" (create (4u))
//printfn "%20A" (rotate (create 4u) (10))
//printfn "%20A" (scramble2 (create 4u) (20u))

printfn "%A" (solved (create (4u)))
printfn "%24A" (scramble2 (create 5u) (20u))