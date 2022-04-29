function map(a, f){
    for(i in a)
        a[i] = f(a[i])
    return a
}

function forEach(a, f){
    for(i in a)
        f(a[i])
}

function filter(a, f){
    var b = []
    for(i in a){
        if(f(a[i])){
            b.push(a[i])
        }
    }
    return b
}

var a = [1, 2, 3, 4]
var f = function(x){
    return x*3
}
var f1 = function(a){
    return console.log(a)
}
var f2 = function(a){
    return a%2 != 0
}


console.log(map(a, x=>x*3))
console.log(map(a, f))

forEach(a, x => console.log(x))
forEach(a, f1)

console.log(filter(a, x => x%2==0))
console.log(filter(a, f2))

