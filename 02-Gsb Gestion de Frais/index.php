<?php
  session_start();
?>
<!DOCTYPE html>
<html >
<head>
  <meta charset="UTF-8">
  <title>Page_de_connexion</title>

      <link rel="stylesheet" href="css/style.css"> 
</head>
<body>
<div style="height: 2em;"></div>
<form id="Ecran" method="post" action="" class="form" autocomplete="false">
<div id="head">
	<h2 id="titre">GSB</h2>
      <h4 id="titre4">Login</h4>
     </div>
<input type="text" class="inpt">
<input type="Password" class="inpt">
  <div class="champ" id="champ1">
    <input type="text" id="log" autocomplete="off" required name="psd" /><hr>
    <label id="log1">Username</label>
  </div>
  <div class="champ"> 
  	<input type="Password" style="display: none">
    <input type="Password" autocomplete="new-password" required  id="log_" name="mdp" /><hr>
    <label id="log1_">Password</label>
  </div>
  <button type="submit" class="Bouton" id="bout" name="submit">Connexion</button>
<script  src="js/index.js"></script>
</body>
</html>
<?php
    include 'include_commercial/Other_php/connexion.php';
?>

