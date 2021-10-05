let dropFirstColumn (llst : 'a list list) : 'a list list =
    let notEmpty = List.forall (fun ( xs : 'a list ) -> xs.IsEmpty = false) llst
    if notEmpty = true then
        List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
    else 
        let sorryBro = [[4];[0];[4]]
        sorryBro

printfn "%A" (dropFirstColumn [[1;2;3];[1;2;3];[1;2;3]])
printfn "%A" (dropFirstColumn [[];[]])
