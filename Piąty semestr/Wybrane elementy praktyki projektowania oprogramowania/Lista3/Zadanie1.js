var foo ={
    pole : 1,
    metoda : function() {
        return "Ala ma kota"
    },
    _wlasciwosc : "Ola",
    get wlasciwosc(){
        return this._wlasciwosc
    },
    set wlasciwosc(s){
        this._wlasciwosc = s
    }
}

console.log(foo.pole)
console.log(foo.metoda())
console.log(foo._wlasciwosc)
console.log(foo.wlasciwosc)
console.log(foo.wlasciwosc = "Ania")

foo.a = "Ewa"
foo.f = function(){
    return "Zosia"
}
console.log(foo.a)
console.log(foo.f())

Object.defineProperty(foo, "bar", {
    get(){
        return "Asia"
    },
    set(x){
        bar = x
    },
})

console.log(foo.bar)
foo.bar = "Ula"
console.log(foo.bar)