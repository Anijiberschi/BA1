<!DOCTYPE html>
<html lang="fr">
	<head>
		<title>pgcd</title>
	</head>
		<body>
			<h1>pgcd</h1>
<?php
	$iA=546757;
	$iB=435757;
	$iR=-1;
	$iPgcd=0;
	
	while ($iR != 0){
		if ($iA%$iB==0){
			$iPgcd =$iR;
			$iR = $iA%$iB;
		}
		$iR = $iA%$iB;
		$iA=$iB;
		$iB=$iR;
	}
	echo "Le pgcd vaut $iPgcd";
?>

	</body>
</html>

	
