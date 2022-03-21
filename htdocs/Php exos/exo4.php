<!DOCTYPE html>
<html lang="fr">
	<head>
		<title>chaine à l'envers</title>
	</head>
		<body>
			<h1>chaine à l'envers</h1>
				<h2>Méthode strrev</h2>
<?php
	$mot='Aristocratie';
	echo "Le mot est $mot<br/>";
	echo strrev("{$mot}");
?>
				<h2>Méthode par tableau</h2>
<?php
	$mot='Aristocratie';
	echo "Le mot est $mot<br/>";
	for ($i=strlen($mot)-1;$i >-1;$i--){
		echo "$mot[$i]";
	}
?>

	</body>
</html>

	
