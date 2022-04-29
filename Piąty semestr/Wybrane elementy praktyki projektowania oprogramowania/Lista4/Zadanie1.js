function Tree(val, left, right) {
    this.left = left;
    this.right = right;
    this.val = val;
}

Tree.prototype[Symbol.iterator] = function*() {
    var queue = [this];
    while( queue.length != 0 ) {
        removed = queue.splice(0, 1)[0];
        if( removed.left ) queue.push( removed.left );
        if( removed.right ) queue.push( removed.right );
        yield removed.val;
    }
}


var root = new Tree(1,
    new Tree(2, new Tree(3)),
                new Tree(4));

var root2 = new Tree(1, 
                new Tree(2, 
                    new Tree(4),
                    new Tree(5, 
                        new Tree(8, 
                            new Tree(10))) ), 
                new Tree(3,
                    new Tree(6),
                    new Tree(7, 
                        new Tree(9))))

for (var e of root2) {
    console.log(e);
}
