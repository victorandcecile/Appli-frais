<?php
$mysql = 'host=localhost';
$bdname = 'ppe_prod';
$charset = 'utf8';
$utilisateur = 'root';
$mdp = '';
$bdd = new PDO('mysql:'.$mysql.';dbname='.$bdname.';charset='.$charset.'',''.$utilisateur.'',''.$mdp.'');
?>