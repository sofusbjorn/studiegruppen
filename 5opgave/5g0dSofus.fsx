let transposeLstLst (llst : 'a list list) : 'a list list =

    /// Checks if llst is empty
    let notEmpty llst = List.forall (fun (xs : 'a list) -> not xs.IsEmpty) llst

    /// Aqquires head of llst
    let firstColumn (llst: 'a list list) : 'a list =
        if notEmpty llst  then
            List.map ( fun (xs: 'a list) -> xs.Head ) llst
        else
            []
    /// Aqquires tail of llst
    let dropFirstColumn (llst : 'a list list) : 'a list list =
        if notEmpty llst then
            List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
        else
            []

    let mutable newList = []
    let mutable oldList = llst
    let runtime = (llst.Item 0).Length - 1

    for i = 0 to runtime do
        newList <- newList @ [(firstColumn oldList)]
        oldList <- dropFirstColumn oldList
        printfn "%A" "HEYY"
    newList

//printfn "%A" (transposeLstLst [[1;2;3];[1;2;3];[1;2;3]])
//printfn "%A" (transposeLstLst [[1;10];[1;10]])
printfn "%A" (transposeLstLst [[];[]])
