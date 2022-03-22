<!DOCTYPE html>
<?php

$chiffreGagnants=array();
$max_row=9;
$max_col=5;
$max_value=$max_col*$max_row;



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

for($i=0; $i <$max_row;$i++)
{
    $form= <<< FDL
    <form name="grille" action="" method="get">\n
    FDL;

	$html.=$form."<tr>\n";
    for ($j=0;$j<$max_col;$j++)
    {
        $number=1+$j+($i*$max_col);
        $ligneTab= <<< FDL
        <td><input type="checkbox" name ="liste[$number]" value="$number" check($number)>$number</td>
        FDL;
        $html.=$ligneTab."\n";
    }
    $html.="</tr>\n";
}
$jouer=<<<EOT
    <input type="submit" value="Jouer"/>
    </form>\n
EOT;
$html.="</table>\n".$jouer."<br><p>Nombre d'elem trouvés</p>";

if (isset($_GET['submit']) && !empty($_GET["list"]))
    {foreach ($_GET['liste'] as &$value){
        $html.="$value";
    }}

$html.="<hr><p>Les bons numéros : </p>";

    for($i=0;$i<6;$i++)
    {
        $chiffreGagnants[$i]=rand(0,$max_value+1);
        $html.="$chiffreGagnants[$i]&nbsp";
    }

    $html.="<hr><p>Vos bons numéros :</p>";

$html.="</body>\n</html>";

echo $html;

function check($number)
{
    if(isset($_GET('Jouer')) && !empty($_GET['grille']))
    {
        if(isset($_GET['grille'][$number]))
            return 'checked';
    }
}

function genRand(){
    $aGriGagnante=array();
    $iCpt=0;
    while($iCpt<6){
        
    }




foreach($_GET['cell'] as $iUnNumero)
{
    if (in_array($iUnNumero,))
}