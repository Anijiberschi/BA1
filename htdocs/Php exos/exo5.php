<!DOCTYPE html>
<html lang="fr">
	<head>
		<title>Palindrome</title>
	</head>
		<body>
			<h1>Exo 5</h1>
				<h2>Palindrome</h2>
<?php
	$mot='kaya';
	$taille=strlen($mot);
	$moitie1='';
	$moitie2='';
	echo "Le mot est $mot<br/>";
	
	for ($i=0;$i <$taille/2;$i++){
		$moitie1.=$mot[$i];
	}
	echo "$moitie1\n";
	for ($i=$taille-1;$i >= ($taille/2)-1;$i--){
		$moitie2.=$mot[$i];
	}
	echo "$moitie2<br>\n";
	
	if ($moitie1 == $moitie2){
		echo "$mot est bel et bien un palindrome<br>";
	}else{
		echo "$mot n'est pas un palindrome<br>";
	}
	echo '<hr>';
?>
<?php
	$mot1='kayak';
	$inverse=strrev($mot1);
	echo "Le mot est $mot1<br>";
	
	
	if ($mot1 == $inverse){
		echo "$mot1 est bel et bien un palindrome<br>";
	}else{
		echo "$mot1 n'est pas un palindrome<br>";
	}
	echo '<hr>';
?>


	</body>
</html>

	
