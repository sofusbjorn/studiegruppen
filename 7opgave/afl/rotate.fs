module rotate
type Position = int
type Board = char list
let rnd = System.Random ()

let create (n : uint ) : Board =
    let lst = ['a' .. 'y']
    lst.[0..((int (n) * int (n))-1)]

let board2Str (b : Board) : string = 
    List.toArray b |> System.String

// not pretty, but it works:)
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

let rec scramble (b : Board) (m : uint) : Board =
    let (boardSize : int) = int(sqrt(double b.Length))
    match m with
    | 0u -> (rotate (b) (allowedRotation (b) (rnd.Next (boardSize))))
    | _ -> (scramble2 (rotate (b) (allowedRotation (b) (rnd.Next (boardSize)))) (m-1u))

let solved (b : Board) : bool =
    let (boardSize : int) = int(sqrt(double b.Length))
    let (solvedBoard : char list) = ['a' .. 'y']
    match b with
    | solvedBoard.[0 .. boardSize*boardSize] -> true
    | _ -> false