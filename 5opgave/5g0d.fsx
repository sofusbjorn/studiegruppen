let transposeLstLst (llst : 'a list list) : 'a list list =

    let firstColumn (llst: 'a list list) : 'a list =
        let notEmpty = List.forall (fun (xs : 'a list) -> xs.IsEmpty = false) llst
        if notEmpty = true then
            List.map ( fun (xs: 'a list) -> xs.Head ) llst
        else
            []
     
    let dropFirstColumn (llst : 'a list list) : 'a list list =
        let notEmpty = List.forall (fun ( xs : 'a list ) -> xs.IsEmpty = false) llst
        if notEmpty = true then
            List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
        else 
            []

    let mutable headerList = firstColumn llst :: []
    let mutable tailList = dropFirstColumn llst

    while tailList.IsEmpty = false do
        headerList <- tailList ::[]
        tailList <- firstColumn tailList
    tailList



printfn "%A" (transposeLstLst [[1;2];[1;2]])