const express = require('express'),
app = express();


app.get('/', (req, res) => {
  res.setHeader('Content-disposition', 'attachment; filename="Plik.txt"');
  res.send('Przykładowy takst');
});

app.listen(3000, () => {
  console.log('started');
})