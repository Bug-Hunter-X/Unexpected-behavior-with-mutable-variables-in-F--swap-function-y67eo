let swap (x, y) = 
    (y, x)

let x, y = 10, 20
let x', y' = swap (x, y)
printf "x = %d, y = %d\n" x' y' //Expected output: x = 20, y = 10

//Alternative approach using a record
type Swappable = { X : int; Y : int }

let swapRecord (s:Swappable) = { s with X = s.Y; Y = s.X }

let myRecord = { X = 10; Y = 20 }
let swappedRecord = swapRecord myRecord
printf "x = %d, y = %d\n" swappedRecord.X swappedRecord.Y