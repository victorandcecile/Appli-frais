<?php include 'config.php'; ?>
<html>
<head>
  <meta charset="UTF-8">
  <title>Page_Commercial</title>
  <link rel="stylesheet" href="//fonts.googleapis.com/icon?family=Material+Icons">
  		<link rel="stylesheet" href="https://storage.googleapis.com/code.getmdl.io/1.0.0/material.amber-pink.min.css" />
  		<link rel="stylesheet" href="https://code.getmdl.io/1.3.0/material.indigo-pink.min.css">
		<script src="https://storage.googleapis.com/code.getmdl.io/1.0.0/material.min.js"></script>
		<link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
      <link rel="stylesheet" href="css/commercial.css"> 
</head>
<?php
session_start();
if(isset($_SESSION['TypeDeConnexion'])){
	if($_SESSION['TypeDeConnexion']==0){
		if(isset($_GET['Date'])){
			$_SESSION['Date']=preg_replace('#/#','.',$_GET['Date']);
		}
		if($_SESSION['Date'][0]=='0'){
			$date=$_SESSION['Date'][1];
		}else{
			$date=substr($_SESSION['Date'],0,2);
		}
		$calendar = array('','de Janvier',' de Fevrier','de Mars',"d'Avril",'de Mai','de Juin','de Juillet',"d'Aout",'de Septembre',"d'Octobre",'de Novembre','de Decembre');
		global $bdd;
		$query = $bdd -> prepare('SELECT Nom,Prenom FROM employe WHERE IDEmploye = :IDEmploye'); 
		$query->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); //redefinir une variable
		$query->execute();
		$data=$query->fetch();
?>
<body>
<div class="mdl-layout__container"><div class="mdl-layout mdl-js-layout ">
  <div class="mdl-layout__drawer" id="layout" style="position: fixed">
    <span class="mdl-layout-title" style="left:15px"><?php echo $data['Prenom'].' '.$data['Nom'] ?></span>
    <div style="border-radius: 50%;margin-left:35px"><img src="img/icone.png" width="150px" height="150px" style="border-radius: 50%;"></div>
    <nav class="mdl-navigation">
      <div class="mdl-navigation__link" id="nav1" style="cursor: pointer;">Fiche En cours</div>
      <div class="mdl-navigation__link" id="nav2" style="cursor: pointer;">Ajouter des Frais</div>
      <div class="mdl-navigation__link" id="nav3" style="cursor: pointer;">Historique</div>
      <div class="mdl-navigation__link" id="nav4" style="cursor: pointer;">Deconnexion</div>
    </nav>
  </div>
  </div>
  </div>
  <div>
<div id="info"><input id='hide2' type="hidden" value="<?php echo date('m.20y')?>"><input id="hide" type="hidden" value="<?php echo "Fiche ".$calendar[$date].' '.date('20y');?>"><div id="titre"><?php echo "Fiche ".$calendar[$date].' 20'.substr($_SESSION['Date'],-2);?></div><div id="titre2">Menu</div></div>
<div class="demo-card-wide mdl-card mdl-shadow--2dp"  id="affichage">
	<?php
	global $bdd;
	$query = $bdd -> prepare('SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && DATEMMYYYY = :DATEMMYYYY');
	$query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
	$query->bindValue('DATEMMYYYY',$_SESSION['Date'], PDO::PARAM_STR); 
	$query->execute();
	$ligne = $query->fetch();
	$query = $bdd -> prepare('SELECT * FROM forfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
	$query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
    $query->bindValue('IDFiche',$ligne['IDFiche'], PDO::PARAM_STR); 
	$query->execute();
	$ligne2 = $query->fetch();
	if($ligne2!=false){
	?>
	<div class="mdl-card__title">
		<h2 class="mdl-card__title-text" id="T1">Frais Forfaitisé</h2>
	</div>
	<div><i class='material-icons' style="right:10px;font-size: 38px;position: absolute;top:10px;color:#333;cursor: pointer;">	picture_as_pdf</i></div>
			<br>
			<br>
			<?php
				include 'include_commercial/Frais_f.php';
			?>
	</div>
	<?php
	}else{
		?>
			<div style='text-align:center;vertical-align: middle;line-height: 180px; font-size:26px'>Pas De Frais Forfaitisé</div>
			<?php
	}
	?>
</div>
<div class="demo-card-wide mdl-card mdl-shadow--2dp" id="affichage_">
	<?php
	global $bdd;
	$query = $bdd -> prepare('SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && DATEMMYYYY = :DATEMMYYYY');
	$query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
	$query->bindValue('DATEMMYYYY',$_SESSION['Date'], PDO::PARAM_STR); 
	$query->execute();
	$ligne = $query->fetch();
	$query = $bdd -> prepare('SELECT * FROM horsforfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
	$query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
    $query->bindValue('IDFiche',$ligne['IDFiche'], PDO::PARAM_STR); 
	$query->execute();
	$ligne2 = $query->fetch();
	if($ligne2!=false){
	?>
	<div class="mdl-card__title">
		<h2 class="mdl-card__title-text" id="T1">Hors-Forfait</h2>
	</div>
		<div><i class='material-icons' style="right:10px;font-size: 38px;position: absolute;top:10px;color:#333;cursor: pointer;">picture_as_pdf</i></div>
			<br>
			<br>
			<?php
				include 'include_commercial/Hors_f.php';
			?>
			</div>
	<?php
	}else{
		?>
			<div style='text-align:center;vertical-align: middle;line-height: 180px;font-size:26px'>Pas De Frais Hors-Forfait</div>
			<?php
	}
	?>
</div>
<div id="affichage3" style="display: none" class="demo-card-wide mdl-card mdl-shadow--2dp">
	<div class="mdl-card__title">
    	<h2 class="mdl-card__title-text" id="T1">Frais Forfaitisé</h2>
  	</div>
	<br>
	<br>
	<?php
		include 'include_commercial/aff_f.php';
	?>
</div>
<div id="affichage2_" style="display: none" class="demo-card-wide mdl-card mdl-shadow--2dp">
	<div class="mdl-card__title">
    	<h2 class="mdl-card__title-text">Hors Forfait</h2>
  	</div>
	<br>
	<br>
	<?php
		include 'include_commercial/aff_h.php';
	?>
</div>
<div id="affichage__" style='display: none' class="demo-card-wide mdl-card mdl-shadow--2dp">
	<div class="mdl-card__title">
    	<h2 class="mdl-card__title-text">Liste des frais</h2>
  	</div>
			<br>
			<br>
			<?php
				include 'include_commercial/History.php';
			?>
	</div>
</div>
</body>
<script src="js/commercial.js"></script>
</html>
<?php
	}else{
		?><i class="material-icons" style="font-size: 160px;position: absolute;left: 280px;top:90px">report_problem</i><div style='font-size: 30;position: absolute;left: 450px;top:150px'>Erreur 404 : Oups Une erreur est survenue<br><br> lors du chargement de la page <a href="index.php" style="color:#e74c3c">>>>ICI<<<</a></div><?php
	}
}else{
	?><i class="material-icons" style="font-size: 160px;position: absolute;left: 280px;top:90px">report_problem</i><div style='font-size: 30;position: absolute;left: 450px;top:150px'>Erreur 404 : Oups Une erreur est survenue<br><br> lors du chargement de la page <a href="index.php" style="color:#e74c3c">>>>ICI<<<</a></div>><?php
}
?>
