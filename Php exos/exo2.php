<!DOCTYPE html>
<?php
$titre = 'table de multiplication';
$html= <<<EOT
<html lang="fr">
	<head>
		<title>table de multiplication</title>
	</head>
		<body>
			<h1>table de multiplication</h1>
			<tr>
				x</th>\n
EOT;

for($i=1; $i <11;$i++)
{
	$html.="$i</th>\n";
}

	$html.="</tr><br>\n";
	$html.="<tr><br>\n";

for($i=1; $i <11;$i++)
{
	$html.="<th>{$i}</th>\n";
	
	for ($j=1;$j<11;$j++){
		$multi=$i*$j;
		$html.="<td>$multi</td>\n";
	}
	$html.="</tr><br>\n";
}


$html.="</tr>\n</body>\n</html>";

echo $html;