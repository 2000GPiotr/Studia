<?php
$IsPostFormData = (isset($_POST["sent"]) && ($_POST["sent"]=="y"));
$IsGetFormData = (isset($_GET["sent"]) && ($_GET["sent"]=="y"));
$imieError = "";
$nazwiskoError = "";
$kartaError = "";
$dataError = "";
$cvcError = "";
$emailError = "";
$telefonError = "";
$kwotaError  = "" ;
?>
<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty($_POST["imie"])) {
        $imieError = "Musisz podac imie";
    } else {
        if (!preg_match("/^[a-zA-Z]*$/", $_POST["imie"])) {
            $imieError = "Nieprawidłowy format imienia";
        }
    }

    if (empty($_POST["nazwisko"])) {
        $nazwiskoError = "Musisz podac nazwisko";
    } else {
        if (!preg_match("/^[a-zA-Z]*$/", $_POST["nazwisko"])) {
            $nazwiskoError = "Nieprawidłowy format nazwiska";
        }
    }

    if ($_POST["karta"][0] == "" or $_POST["karta"][1] == "" or $_POST["karta"][2] == "" or $_POST["karta"][3] == "") {
        $kartaError = "Musisz podac numer karty";
    } else {
        if (!preg_match("/^[0-9]{4}$/", $_POST["karta"][0]) or !preg_match("/^[0-9]{4}$/", $_POST["karta"][1]) or !preg_match("/^[0-9]{4}$/", $_POST["karta"][2]) or !preg_match("/^[0-9]{4}$/", $_POST["karta"][3])) {
            $kartaError = "Nieprawidłowy format numeru karty";
        }
    }


    if ($_POST["data"][0] =="" or $_POST["data"][1] =="") {
        $dataError = "Musisz podac date waznosci karty";
    } else {
        if ((!preg_match("/^1[0-2]$/", $_POST["data"][0]) or !preg_match("/^|0[1-9]$/", $_POST["data"][0])) or !preg_match("/^20[2-9][0-9]$/",  $_POST["data"][1] )) {
            $dataError = "Nieprawidłowy format daty";
        }
    }

    if (empty($_POST["cvc"])) {
        $cvcError = "Musisz podac cvc karty";
    } else {
        if (!preg_match("/^[0-9]{3}$/", $_POST["cvc"])) {
            $cvcError = "Nieprawidłowy format CVC";
        }
    }


     if (empty($_POST["email"])) {
         $emailError = "Musisz podac email";
     } else {

         if (!filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)) {
             $emailError = "Nieprawidłowy format adresu email";
         }
     }

    if (empty($_POST["telefon"])) {
        $telefonError = "Podaj numer telefonu";
    } else {
        if (!preg_match("/^[0-9]{9}$/", $_POST["telefon"])) {
            $telefonError = "Nieprawidłowy format numeru telefonu ";
        }
    }

    if (empty($_POST["kwota"])) {
        $kwotaError = "Podaj kwote";
    } else {
        if (!preg_match("/^[0-9]+$/", $_POST["kwota"])) {
            $kwotaError = "Nieprawidłowy format kwoty przelewu";
        }
    }

}
?>



<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
"http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>Zadanie2</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<style type="text/css">
td,th,body { font-family:Verdana, Arial, Helvetica, sans-serif; font-size:10pt; }
/* Chrome, Safari, Edge, Opera */
input::-webkit-outer-spin-button,
input::-webkit-inner-spin-button {
    -webkit-appearance: none;
    margin: 0;
}

/* Firefox */
input[type=number] {
    -moz-appearance: textfield;
}
.error {color: red;}
</style>
</head>

<body>

<h3 align="center">Płatność</h3>

<form name="dane" action="Zadanie2.php" method="post">
<table align="center" cellpadding="4" cellspacing="2" border="0" bgcolor="#00FFFF">
    <tr><th align="left">Imię:</th><td><input name="imie" type="text" size="15" maxlength="20" value= "<?php echo $_POST["imie"]; ?>" </td><td><span class="error"><?php echo $imieError;?></td></tr>
    <tr><th align="left">Nazwisko:</th><td><input name="nazwisko" type="text" size="20" maxlength="40" value="<?php echo $_POST["nazwisko"]; ?>"></td><td><span class="error"><?php echo $nazwiskoError;?></span></td></tr>
    <tr><th align="left">Numer karty:</th><td>
            <input name="karta[]" type="number" size="6" maxlength="4" minlength="4" value="<?php echo $_POST["karta"][0]; ?>">
            <input name="karta[]" type="number" size="6" maxlength="4" minlength="4" value="<?php echo $_POST["karta"][1]; ?>">
            <input name="karta[]" type="number" size="6" maxlength="4" minlength="4" value="<?php echo $_POST["karta"][2]; ?>">
            <input name="karta[]" type="number" size="6" maxlength="4" minlength="4" value="<?php echo $_POST["karta"][3]; ?>"></td><td><span class="error"><?php echo $kartaError;?></span></td></tr>
<tr><th align="left">Data ważności karty(MM-RRRR)</th><td>
        <input name="data[]" type="number" size="4" maxlength="2" minlength="2" value="<?php echo $_POST["data"][0]; ?>">
        <input name="data[]" type="number" size="4" maxlength="2" minlength="2" value="<?php echo $_POST["data"][1]; ?>"></td><td><span class="error"><?php echo $dataError;?></span></td></tr>
    <tr><th align="left">CVC</th><td><input name="cvc" type="number" size="4" maxlength="3" value="<?php echo $_POST["cvc"]; ?>"></td><td><span class="error"> <?php echo $cvcError;?></span></td></tr>
    <tr><th align="left">Email:</th><td><input name="email" type="text" size="20" value="<?php echo $_POST["email"]; ?>"></td><td><span class="error"><?php echo $emailError;?></span></td></tr>
    <tr><th align="left">Numer telefonu:</th><td><input name="telefon" type="text" size="20" value="<?php echo $_POST["telefon"]; ?>"></td><td><span class="error"><?php echo $telefonError;?></span></td></tr>
    <tr><th align="left">Kwota:</th><td><input name="kwota" type="text" size="20" value="<?php echo $_POST["kwota"]; ?>"></td><td><span class="error"><?php echo $kwotaError;?></span></td></tr>


								   
<tr><td align="right" colspan="2"><input type="submit" value="Wyślij"></td></tr>
</table>
<input name="sent" type="hidden" value="y">
</form>

<?php
if ( $IsPostFormData ):
?>
<table cellpadding="4" cellspacing="2" border="1" align="center">
    <tr><th>Imię:</th><td><?php echo $_POST["imie"]; ?></td></tr>
    <tr><th>Nazwisko:</th><td><?php echo $_POST["nazwisko"]; ?></td></tr>
    <tr><th>Numer karty:</th><td><?php echo join($_POST["karta"],"-"); ?></td></tr>
    <tr><th>Data ważności karty(MM-RRRR):</th><td><?php echo join($_POST["data"],"/"); ?></td></tr>
    <tr><th>CVC:</th><td><?php echo $_POST["cvc"]; ?></td></tr>
    <tr><th>Email:</th><td><?php echo $_POST["email"]; ?></td></tr>
    <tr><th>Numer telefonu:</th><td><?php echo $_POST["telefon"]; ?></td></tr>
    <tr><th>Kwota:</th><td><?php echo $_POST["kwota"]; ?></td></tr>
</table>

<?php
endif;
?>


</body>
</html>