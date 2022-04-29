function fibonacci_rec(x)
{
    if(x<3)
    {
        return 1;
    }
    else
    {
        return fibonacci_rec(x-1) + fibonacci_rec(x-2);
    }
}

function fibonacci_iter(x)
{
    var n1 = 1;
    var n2 = 1;

    if(x<3)
        return 1;

    for(var i=2; i<x; i++)
    {
        var pom = n1+n2;
        n1 = n2;
        n2 = pom;
    }
    return n2;
}

var num = 40;

console.time("Iteration function time");
for(var i=10; i<num; i++)
{
    console.log(fibonacci_iter(i));    
}
console.timeEnd("Iteration function time")

console.time("Recursive function time");
for(var i=10; i<num; i++)
{
    console.log(fibonacci_rec(i));    
}
console.timeEnd("Recursive function time")
/*
Dla num = 48:
Iteration function time: 34.589ms
Recursive function time: 2:11.178 (m:ss.mmm)

Dla num = 40
Iteration function time: 15.033ms
Recursive function time: 2.787s
*/

/*Chrome
Dla num = 40
Iteration function time: 2.864990234375ms
Recursive function time: 2103.412109375ms
*/

/*Edge
Dla num = 40
Iteration function time: 2.730224609375 ms
Recursive function time: 1418.81787109375 ms
*/

// w przeglądarkach działa nieco szybciej, funkcja iteracyjna nawet sporo szybciej