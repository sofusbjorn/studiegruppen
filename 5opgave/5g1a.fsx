let transposeArr (arr : 'a [,])  =
      

      let height = Array2D.length1 arr
      let width = Array2D.length2 arr
      Array2D.init width height ( fun r c -> arr.[c,r] )

let x  = array2D  [[1;2;3]; [4;5;6] ]
let empty = Array2D.init 0 0 (fun x y -> x*y)
printfn "%A" (transposeArr x)
printfn "%A" (transposeArr empty)
printfn "%A" x 


  
