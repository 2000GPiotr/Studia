var http = require ('http');
var express = require('express');

app = express();
bodyParser = require('body-parser');

app.set('view engine', 'ejs');
app.set('views', './views');

app.use(bodyParser.urlencoded({extended: true}));

app.get('/', (req, res) => {
  res.render('form');
});

app.post('/', (req, res) => {
  if (
    !req.body.firstName ||
    !req.body.lastName  ||
    !req.body.subject   
  ) {
    return res.redirect('/');
  }
  var firstName = req.body.firstName;
  var lastName  = req.body.lastName;
  var subject   = req.body.subject;
  let exercises = [];
  for (let [name, score] of req.body.exercises.entries()) {
    score = score ? score : 0;
    exercises.push({
      name,
      score
    });
  }
  res.render('print', { firstName, lastName, subject, exercises});
});


app.listen(3000, () => {
  console.log('started');
});