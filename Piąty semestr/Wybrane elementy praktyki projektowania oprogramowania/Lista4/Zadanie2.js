var Foo = (function() {
    function Bar() {
        Qux();
        console.log("Zawołano Bar");
    }

    function Qux() {
        console.log("Zawołano Qux");
    }

    function Foo() {}

    Foo.prototype.Bar = Bar;

    return Foo;
}());

var foo = new Foo();

foo.Bar();
// foo.Qux(); // Przy próbie wywołania zwraca błąd