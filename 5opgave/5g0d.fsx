<<<<<<< HEAD
let firstColumn (llst: 'a list list) : 'a list =
  let notEmpty = List.forall (fun (xs : 'a list) -> xs.IsEmpty = false) llst
  if notEmpty = true then
    List.map ( fun (xs: 'a list) -> xs.Head ) llst
  else
    let emptyList = []
    emptyList 

let dropFirstColumn (llst : 'a list list) : 'a list list =
    let notEmpty = List.forall (fun ( xs : 'a list ) -> xs.IsEmpty = false) llst
    if notEmpty = true then
        List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
    else 
        []

let transposeLstLst (llst : 'a list list ) = 
 let mutable c = []
 for x in llst do 
   let y = firstColumn llst
   c <- c @ y
   dropFirstColumn llst
  printfn "%A" c

let q = [[1;2;3]; [4;5;6]]
printfn "%A" q
=======
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
>>>>>>> 0ef5359123cc2a6440c18e259725dda7ec0675e0
