<!DOCTYPE html>
<?php
$cCarreDe = 'Le carre de ';
$html= <<<EOT
<html lang="fr">
	<head>
		<title>Carré de </title>
	</head>
		<body>
			<h1>Le carré de</h1>
EOT;

for($i=0; $i <10;$i++)
{
	$carre=$i*$i;
	$html.="$cCarreDe $i vaut $carre <br/>";
}
$html.="</body>\n</html>";

echo $html;