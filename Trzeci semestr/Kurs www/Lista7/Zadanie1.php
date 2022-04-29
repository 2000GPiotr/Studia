<!doctype HTML>
<head>
<meta chrset="utf-8">
<title>Zadanie1</title>
</head>
<body>
<h1>PHP INFO</h1>
<?php
        echo phpinfo();
?>

<h2>$_SERVER </h2>
<?php
        foreach ($_SERVER as $key => $value)
        echo $key.'='.$value.'<br />';
?>


</body>