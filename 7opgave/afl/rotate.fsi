module rotate
/// indsæt noget med type: board og type Position
type Position = int
type Board = char list
val create : n:uint -> Board
val board2Str : b:Board -> string
val validRotation : b:Board -> p:Position -> bool
val rotate : b:Board -> p:Position -> Board
val scramble : b:Board -> m:uint -> Board
val solved : b:Board -> bool  