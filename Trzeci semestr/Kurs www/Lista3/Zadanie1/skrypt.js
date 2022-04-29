function nrKontaValidation()
{
    var nrkontaStrPattern = new RegExp(/[0-9]{26}/);
    var nrkontaStr = document.getElementById("nrkonta").value;
    if(!nrkontaStrPattern.test(nrkontaStr))
    {
        alert("Numer konta musi mieć 26 cyfr");
    }
}

function peselValidation()
{
    var peselStrPattern = new RegExp(/[0-9]{11}/);
    var peselStr = document.getElementById("pesel").value;
    if(!peselStrPattern.test(peselStr))
    {
        alert("PESEL musi mieć 11 cyfr");
    }
}

function dateValidation()
{
    var dateStrPattern = new RegExp(/[0,1,2,3][0-9],[0,1][0-9],[0-9]{4}/);
    var dateStr = document.getElementById("data").value;
    if(!dateStrPattern.test(dateStr))
    {
        alert("Prawidłowy format daty to dd,mm,rrrr");
    }
}

function emailValidation()
{
    var emailStrPattern = new RegExp(/w{1,}+\@w{1,}+\.w{2,3}/);
    var emailStr = document.getElementById("email").value;
    if(!emailStrPattern.test(emailStr))
    {
        alert("Nieprawidłowy adres email");
    }
}


function validation()
{
    nrKontaValidation()
    peselValidation()
    dateValidation()
    emailValidation()
}


const nrkonta = document.getElementById('nrkonta');
nrkonta.addEventListener('focusout', (event) => {
    nrKontaValidation();
});

const pesel = document.getElementById('pesel');
pesel.addEventListener('focusout', (event) => {
    peselValidation();
});

const data = document.getElementById('data');
data.addEventListener('focusout', (event) => {
    dateValidation();
});

const email = document.getElementById('email');
email.addEventListener('focusout', (event) => {
    emailValidation();
});

const submit_btn = document.getElementById('submit_btn');
submit_btn.addEventListener('click', (event) => {
    validation();
});


