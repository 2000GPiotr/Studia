<?php
/*** set the content type header ***/
/*** Without this header, it wont work ***/
/*header("Content-type: txt/css");
*/

$font_family = 'Arial, Helvetica, sans-serif';
$font_size = '12';
$border = '1px solid';
$color = '#0010FF';
?>
 body {
    background-color: <?php echo $color ?>;
 }


table {
margin: 8px;
}

th {
font-family: <?=$font_family?>;
font-size: <?=$font_size?>;
background: #123;
color: #FFF;
padding: 2px 6px;
border-collapse: separate;
border: <?=$border?> #000;
}

td {
font-family: <?=$font_family?>;
font-size: <?=$font_size?>;
border: <?=$border?> #DDD;
color: #FFF;
}