let dropFirstColumn (llst : 'a list list) : 'a list list =
    let notEmpty = List.forall (fun ( xs : 'a list ) -> xs.IsEmpty = false) llst
    if notEmpty = true then
        List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
    else 
        []

printfn "%A" (dropFirstColumn [[1;2;3];[1;2;3];[1;2;3]])
printfn "%A" (dropFirstColumn [[];[]])
