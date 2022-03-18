<!DOCTYPE html>
<html lang="fr">
	<head>
		<title>bottle ding dong</title>
	</head>
		<body>
			<h1>bottle ding dong</h1>
<?php
$html;
for($i=1; $i <101;$i++)
{
	if ($i%5==0){
		$html.='bottle ';
	}
	if ($i%7==0){
		$html.='ding-dong';
	}
	else{
		$html="$i";
	}
	echo "$html<br>\n";
	$html='';
}?>
	</body>
</html>

	
