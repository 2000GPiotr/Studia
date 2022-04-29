function fib(n){
    if(n<3){
        return 1
    }
    else{
        return(fib(n-1) + fib(n-2))
    }
}

function memo(f){

    var cache = {}

    return function(n){
        if(cache[n] === undefined){
            var f_n = f(n)
            cache[n] = f_n
            return f_n

        }else{
            return cache[n]

        }

    }
}

var fib = memo(fib)

console.log(fib(1000))
console.log(fib(400))