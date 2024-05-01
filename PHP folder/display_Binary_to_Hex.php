<?php
$hostname = 'localhost';
$username = 'root';
$password = '';
$database = 'matching_your_bases';
 
try 
{
	$dbh = new PDO('mysql:host='. $hostname .';dbname='. $database, 
         $username, $password);
} 
catch(PDOException $e) 
{
	echo '<h1>An error has occurred.</h1><pre>', $e->getMessage()
            ,'</pre>';
}
 
$sth = $dbh->query('SELECT Name, Time FROM `score` WHERE Game like 3 ORDER BY Time ASC LIMIT 10');
$sth->setFetchMode(PDO::FETCH_ASSOC);
 
$result = $sth->fetchAll();
 
if (count($result) > 0) 
{
	foreach($result as $r) 
	{
		echo $r['Name'], "\n _";
		echo $r['Time'], "\n _";
	}
}
?>