let isTable ( llst : 'a list list ) : bool =
  let llst1 = llst.Item 0
  let len1 = llst1.Length
  let sameLen = List.forall  (fun (xs: 'a list) -> xs.Length = len1) llst
  let notEmpty = List.forall (fun (xs : 'a list) -> xs.IsEmpty = false) llst
  if sameLen = true && notEmpty = true then true else false 

let x = [[1;2;3;4]; [1;2;3;4]]
let y = [[1;2;3;4];[]; [1;2;3;4]]
let z = [[]]
let q = [[];[]]
let d = [[6;5;4;3];[1;3;4;5];[1;2;3;4]; [1;2;3;4]]
printfn "%A" (isTable x)
printfn "%A" (isTable y)
printfn "%A" (isTable z)
printfn "%A" (isTable q)
printfn "%A" (isTable d)
  
