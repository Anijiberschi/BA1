<?php
session_start();

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

// on défini les paramètres de connexion à la DB
$host='localhost';
$user='admin';
$pass='milou';
$db='ig1';

$dsn = "mysql:host={$host};dbname={$db}";


try 
{
	$dbh = new PDO($dsn, $user, $pass); //db handle
	$dbh->exec('SET NAMES utf8');
} 
catch (PDOException $e) 
{
	die( 'Erreur ! : ' . $e->getMessage() );
}


$sql = 'SELECT * FROM users';

// formulaire
$sFormulaire = <<<EOT
	<form method="post" action="login.php">
		Login : <input type="text" name="login"><br>
		Password : <input type="password" name="password"><br>
		<input type="submit" name="auth">
	</form>
EOT;

$sBody .= $sFormulaire;

// action
$sMessageErreur = '';

if(isset($_GET['logout']))
{
	session_destroy();
}

if(isset($_SESSION['auth']))
{
	header('Location: bienvenue.php');
}

if(isset($_POST['auth']))
{
	if(!empty($_POST['login']) AND !empty($_POST['password']))
	{
		if($_POST['login'] == 'bobo' AND $_POST['password'] == 'pipo')
		{
			// connected
			// gérer la session
			// redirection
			$sMessageErreur = 'authentification réussie';
			$_SESSION['auth'] = 'role...';
			header('Location: bienvenue.php');
		}
		else
		{
			// mauvais login et/ou password
			// afficher form
			$sMessageErreur = 'mauvais login et/ou password';
		}
	}
	else
	{
		// message erreur
		// afficher form
		$sMessageErreur = 'Veuillez remplir les 2 champs';
	}
}
else
{
	// afficher form
}

$sBody .= $sMessageErreur;



// affichage 
echo $sDebutHtml.$sBody.$sFinHtml;







