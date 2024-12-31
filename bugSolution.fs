let x = 10
let y = 20

let swap x y =
    (y, x)

let x', y' = swap x y
printf "%d %d" x' y' // Output: 20 10

//Alternative using tuples:
let swapTuple (x,y) = (y,x)
let x'',y'' = swapTuple (x,y)
printf "%d %d" x'' y'' // Output: 20 10