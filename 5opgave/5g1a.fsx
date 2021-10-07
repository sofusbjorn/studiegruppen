let transposeArr (arr : 'a [,])  =
<<<<<<< HEAD
      

      let height = Array2D.length1 arr
      let width = Array2D.length2 arr
      Array2D.init width height ( fun r c -> arr.[c,r] )

let x  = array2D  [[1;2;3]; [4;5;6] ]
let empty = Array2D.init 0 0 (fun x y -> x*y)
printfn "%A" (transposeArr x)
printfn "%A" (transposeArr empty)
=======
  let height = Array2D.length1 arr
  let width = Array2D.length2 arr
  Array2D.init width height ( fun r c -> arr.[c,r] )

let x  = array2D  [[1;2;3]; [4;5;6] ]
printfn "%A" (transposeArr x)
>>>>>>> ee4becc73bbbabf74ba4917e63fa77ca61954bc2
printfn "%A" x 


  
