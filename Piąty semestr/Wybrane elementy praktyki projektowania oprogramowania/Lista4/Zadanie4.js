let input = process.stdin;

input.setEncoding("utf-8")

process.stdout.write("Podaj swoje imię: ");

input.on("data", function(data) {
    process.stdout.write("Witaj " + data);
    process.exit();
})
