<!DOCTYPE html>
<?php
$html= <<<'EOT'
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lotto</title>
</head>
<body>
<h1>Lotto</h1>
<table border="1">
EOT;

for($i=0; $i <9;$i++)
{
    $form= <<< FDL
    <form name="grille" action="" method="get">\n
    FDL;

	$html.=$form."<tr>\n";
    for ($j=0;$j<5;$j++)
    {
        $number=1+$j+($i*5);
        $ligneTab= <<< FDL
        <td><input type="checkbox" name ="liste[] value="$number">$number</td>
        FDL;
        $html.=$ligneTab."\n";
    }
    $html.="</tr>\n";
}
$jouer=<<<EOT
<input type="submit" value='."Jouer"/>
</form>\n
EOT;
$html.="</table>\n".$jouer;


$html.="</body>\n</html>";

echo $html;