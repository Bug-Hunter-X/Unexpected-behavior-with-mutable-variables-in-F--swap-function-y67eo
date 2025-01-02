let mutable x = 10
let mutable y = 20
let mutable z = 30

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "x = %d, y = %d\n" x y

//Expected output: x = 20, y = 10
//Actual output: x = 20, y = 10