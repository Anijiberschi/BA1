<?php

$sDebutHtml = <<<EOT
<!DOCTYPE html>
<html>
	<head>
		<title>Demo sessions auth</title>
		<meta charset="utf-8" />
	</head>
	<body>
EOT;

$sBody = '';
	
$sFinHtml = <<<EOT
	</body>
</html>
EOT;

//
session_start();
if(isset($_SESSION['auth']))
{
	// on est connecté
	$sBody .= 'Bienvenue';
	$sBody .= <<<EOT
	<br><a href="login.php?logout">logout</a>
EOT;
}
else
{
	$sBody .= 'Veuillez vous authentifier !';
	header('Location: login.php');
	// redirection
}


// affichage 
echo $sDebutHtml.$sBody.$sFinHtml;







