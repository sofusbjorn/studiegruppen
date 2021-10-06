/// <summary> Funktionen firstColumn tager imod vilkårlig liste af lister. Hvis der ikke er nogen tomme indrelister
/// retuneres en liste med de første elementer af de indre lister, ellers retuneres en tom liste.</summary>
/// <param name = "llst"> En aplpha liste af lister. </param>
/// <returns> En liste med de første elementer af den indre liste, 
/// hvis der ikke er nogen tomme lister i "llst", ellers retuneres en tom liste. </returns>
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
