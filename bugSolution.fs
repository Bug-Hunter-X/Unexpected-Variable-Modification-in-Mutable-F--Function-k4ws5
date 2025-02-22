let x = 10
let y = 20

let add x y = 
    let mutable sum = x + y
    sum <- sum + x
    sum <- sum + y
    sum

printf "%A" (add x y)