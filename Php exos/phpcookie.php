<!DOCTYPE html>
<?php 
$html = <<<'EOT'
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>phpcookie</title>
</head>
<body>
EOT;


$sFormulaire = <<< 'EOT'
<form action="" method="get">
    Login: <input type="login" value="login"><br>
    Password: <input type="password" value="password">
<input type="submit" value="valider"/>
EOT;


$html.=$sFormulaire;


$html.= <<< 'EOT'
</body>
</html>
EOT;

echo $html;