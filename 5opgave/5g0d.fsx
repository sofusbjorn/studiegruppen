let transposeLstLst (llst : 'a list list) : 'a list list =

    let firstColumn (llst: 'a list list) : 'a list =
        let notEmpty = List.forall (fun (xs : 'a list) -> xs.IsEmpty = false) llst
        if notEmpty = true then
            List.map ( fun (xs: 'a list) -> xs.Head ) llst
        else
            []
     
    
GØR NOGET MED 5goC OGSÅ!