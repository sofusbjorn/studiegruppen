let firstColumn (llst: 'a list list) : 'a list =
  let notEmpty = List.forall (fun (xs : 'a list) -> xs.IsEmpty = false) llst
  if notEmpty = true then
    List.map ( fun (xs: 'a list) -> xs.Head ) llst
  else
    let emptyList = []
    emptyList 
    

    
printfn "%A" (firstColumn [[1;2;3;4]; [5;6;7;8]])
printfn "%A" (firstColumn [[1;2;3;4]; [5;6;7;8]; []])
printfn "%A" (firstColumn [[1;2;3;4]; [5;6;7;8]; [1;2]])
printfn "%A" (firstColumn [[];[]])
