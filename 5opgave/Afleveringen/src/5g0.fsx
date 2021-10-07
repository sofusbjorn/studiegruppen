/// <summary> Tester om en vilkårlig liste er tom</summary>
/// <param name: "llst" >En vilkårlig liste </param>
/// <returns> Returnerer false hvis listen er tom, ellers true </returns>
let notEmpty llst = List.forall (fun (xs : 'a list) -> not xs.IsEmpty) llst

/// <summary>  Funktionen isTable tager en vilkårlig liste af lister, og undersøger om de er tabeller. 
/// For at være en tabel må listen af lister ikke indeholde nogen tomme lister, 
/// og alle listerne i listen skal være lige lange. </summary>
/// <param name: "llst" > En alpha liste af lister. </param>
/// <returns> Hvis llst er en tabel retuneres true, hvis llst ikke er en tabel retuneres false. </returns>

let isTable ( llst : 'a list list ) : bool =
  let llst1 = llst.Item 0
  let len1 = llst1.Length
  let sameLen = List.forall  (fun (xs: 'a list) -> xs.Length = len1) llst
  if sameLen && notEmpty llst then true 
  else 
    false 

/// <summary> Funktionen firstColumn tager imod vilkårlig liste af lister. Hvis der ikke er nogen tomme indrelister
/// retuneres en liste med de første elementer af de indre lister, ellers retuneres en tom liste.</summary>
/// <param name = "llst"> En aplpha liste af lister. </param>
/// <returns> En liste med de første elementer af den indre liste, 
/// hvis der ikke er nogen tomme lister i "llst", ellers retuneres en tom liste. </returns>
let firstColumn (llst: 'a list list) : 'a list =
  if notEmpty llst then
    List.map ( fun (xs: 'a list) -> xs.Head ) llst
  else
    let emptyList = []
    emptyList
 
/// <summary> Funtionen dropFirstColumn tager en vilkårlig liste af lister, 
/// og hvis der ikke er nogen tomme indre lister, retuneres en liste af lister,
/// hvor det første element i hver indre liste er fjernet. Hvis der er en tom indre liste,
/// retuneres en tom liste. </summary>
/// <param name = "llst"> En aplha liste af lister. </param>
/// <returns> Hvis der ikke er nogen tomme lister i "llst" retuneres en liste af lister. 
/// Hvis der er en tom liste i "llst" retuneres en tom liste. </returns>
let dropFirstColumn (llst : 'a list list) : 'a list list =
    if notEmpty llst then
        List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
    else 
        []

/// <summary> Transponerer en liste af lister</summary>
/// <param name: "llst" >En vilkårlig liste </param>
/// <returns> En transponeret liste af lister eller en tom liste hvis inputtet er en tom liste af lister</returns>
let transposeLstLst (llst : 'a list list) : 'a list list =
    
    let mutable newList = []
    let mutable oldList = llst
    let runtime = (llst.Item 0).Length - 1

    for i = 0 to runtime do
        newList <- newList @ [(firstColumn oldList)]
        oldList <- dropFirstColumn oldList
    newList

///WHITEBOX-TEST TID
printfn "White-box testing af alle 5g0's funktioner"
printfn " "
printfn "isTable:"
printfn " %5b: Branch 1a" (isTable [[1;2;3];[4;5;6]] = true)
printfn " %5b: Branch 1b" (isTable [[1;2];[3;4;5]] = false)
printfn " %5b: Branch 1c" (isTable [[];[]] = false)
printfn " %5b: Branch 1d" (isTable [[];[1;2]] = false)
printfn " "
printfn "firstColumn:"
printfn " %5b: Branch 1a" (firstColumn [[1;2;3];[4;5;6]] = [1;4])
printfn " %5b: Branch 1b" (firstColumn [[];[]] = [])
printfn " "
printfn "dropFirstColumn:"
printfn " %5b: Branch 1a" (dropFirstColumn [[1;2;3];[4;5;6]] = [[2;3];[5;6]])
printfn " %5b: Branch 1b" (dropFirstColumn [[];[]] = [])
printfn " "
printfn "transposeLstLst:"
printfn " %5b: Branch 1a" (transposeLstLst [[1;2;3];[4;5;6]] = [[1;4];[2;5];[3;6]])
printfn " %5b: Branch 1b" (transposeLstLst [[];[]] = []) //HER TESTES ET INPUT DER IKKE GÅR IND I FOR-LØKKEN
