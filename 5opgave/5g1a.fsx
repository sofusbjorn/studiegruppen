let transposeArr (arr : 'a [,])  =
  let height = Array2D.length1 arr
  let width = Array2D.length2 arr
  Array2D.init width height ( fun r c -> arr.[c,r] )

let x  = array2D  [[1;2;3]; [4;5;6] ]
printfn "%A" (transposeArr x)
printfn "%A" x 


  
