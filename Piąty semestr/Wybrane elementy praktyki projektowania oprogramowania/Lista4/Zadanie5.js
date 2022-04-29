const fs = require('fs');

function read(path) {
    return fs.readFile(path, 'utf-8', (err, data) => {
        if (err) throw err;
        
        console.log(data);
    })
};

read('text.txt');