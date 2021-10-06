/// <summary> Funtionen dropFirstColumn tager en vilkårlig liste af lister, 
/// og hvis der ikke er nogen tomme indre lister, retuneres en liste af lister,
/// hvor det første element i hver indre liste er fjernet. Hvis der er en tom indre liste,
/// retuneres en tom liste. </summary>
/// <param name = "llst"> En aplha liste af lister. </param>
/// <returns> Hvis der ikke er nogen tomme lister i "llst" retuneres en liste af lister. 
/// Hvis der er en tom liste i "llst" retuneres en tom liste. </returns>
let dropFirstColumn (llst : 'a list list) : 'a list list =
    let notEmpty = List.forall (fun ( xs : 'a list ) -> xs.IsEmpty = false) llst
    if notEmpty = true then
        List.map ( fun (xs : 'a list ) -> xs.Tail ) llst
    else 
        []

printfn "%A" (dropFirstColumn [[1;2;3];[1;2;3];[1;2;3]])
printfn "%A" (dropFirstColumn [[];[]])
