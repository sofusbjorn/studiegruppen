/// <summary> Transponerer et vilkårligt to-dimensionelt array</summary>
/// <param name: "arr" >Et vilkårligt to-dimensionelt array</param>
/// <returns> Returnerer det transponerede 2D array</returns>

let transposeArr (arr : 'a [,])  =
    
    let height = Array2D.length1 arr
    let width = Array2D.length2 arr
    Array2D.init width height ( fun r c -> arr.[c,r] )

///WHITEBOX-TEST TID
printfn "White-box testing af alle 5g1's funktioner"
printfn " "
printfn "transposeArr:"
printfn "Vi har taget beslutningen om ikke at lave en White-box test af transposeArr, da den ikke inkluderer én eneste branch."
printfn "(-(-_(-_-)_-)-)"

/// Opgave 5g1c:
/// Funktionen der benytter arrays er meget simplere, da den kun benytter en enkelt funktion, 
/// og ikke både, firstColumn og dropFirstColumn som i transposeLstLst.
/// Derfor er transposeArr meget lettere at debugge og vedligeholde.
/// Man kunne forestille sig at det ville være lettere for en programmør at forstå hvordan koden er sat op i transposedLstLst,
/// da det er nemmere at gennemskue hvilke steps programmet foretager sig.

/// Opgave 5g1d:
/// Når det kommer til arrays, vil vi argumentere for at de er bedre programmeret i det funktionelle paradigme,
/// fordi der skal bruges mindre kode, da de inbyggede funktioner klarer jobbet lettere.
/// Vi vil dog argumentere for at lister er bedst programmeret i det imperative paradigme, da det er nødvendigt med både:
/// Loops og mutable variable.

