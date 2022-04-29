module.exports = { fa };
let module2 = require('./Zadanie3_2');

function fa(n) {
    if (n > 0) {
        console.log(`a: ${n}`);
        module2.fb(n - 1);
    }
}