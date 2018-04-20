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
	if($_SESSION['TypeDeConnexion']==1){
		if(isset($_GET['IDSelect'])){
			$_SESSION['IDSelect']=$_GET['IDSelect'];
			header('Location: comptable.php');
		}
		if(isset($_GET['IDFicheSelect'])){
			$_SESSION['IDFicheSelect']=$_GET['IDFicheSelect'];
			header('Location: comptable.php');
		}
		$calendar = array('','De Janvier',' De Fevrier','De Mars',"d'Avril",'De Mai','De Juin','De Juillet',"D'Aout",'De Septembre',"D'Octobre",'De Novembre','De Decembre');
		global $bdd;
		$query = $bdd -> prepare('SELECT Nom,Prenom FROM employe WHERE IDEmploye = :IDEmploye'); 
		$query->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); //redefinir une variable
		$query->execute();
		$data=$query->fetch();
?>
<body>
<div class="mdl-layout__container"><div class="mdl-layout mdl-js-layout ">
  <div class="mdl-layout__drawer" id="layout" style="position: fixed">
    <span class="mdl-layout-title" style="margin-left:10px"><?php echo $data['Prenom'].' '.$data['Nom'] ?></span>
    <div style="border-radius: 50%;margin-left:35px"><img src="img/icone.png" width="150px" height="150px" style="border-radius: 50%;"></div>
    <nav class="mdl-navigation">
      <div class="mdl-navigation__link" id="nav3" style="cursor: pointer;">Gestion Des Listes</div>
      <div class="mdl-navigation__link" id="nav4" style="cursor: pointer;">Deconnexion</div>
    </nav>
  </div>
  </div>
  </div>
  <div>
<div id="info"><input id='hide2' type="hidden" value="<?php echo date('m.20y')?>"><div id="titre">Gestion Des Fiches</div><div id="titre2">Menu</div></div>
<div id="affichage" >
	<div id="affichage" class="demo-card-wide mdl-card mdl-shadow--2dp">
		<div class="mdl-card__title">
			<h2 class="mdl-card__title-text" id="T1">
				<?php if($_SESSION['IDSelect']!=0 && $_SESSION['IDFicheSelect']==0){
				global $bdd;	
				$query = $bdd -> prepare('SELECT Nom,Prenom FROM employe WHERE IDEmploye = :IDEmploye'); 
		        $query->bindValue(':IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_INT); //redefinir une variable
		        $query->execute();
		        $ligne=$query->fetch();
		        echo "Fiches De ".$ligne['Prenom'].' '.$ligne['Nom'];
			}else if($_SESSION['IDSelect']!=0 && $_SESSION['IDFicheSelect']!=0){
				$query = $bdd -> prepare('SELECT DateMMYYYY FROM fiche WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche'); 
		        $query->bindValue(':IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_INT); //redefinir une variable
		        $query->bindValue(':IDFiche',$_SESSION['IDFicheSelect'], PDO::PARAM_INT); //redefinir une variable
		        $query->execute();
		        $ligne=$query->fetch();
		        if($ligne['DateMMYYYY'][0] == 0) {
		        	echo "Fiches ".$calendar[$ligne['DateMMYYYY'][1]].' '.substr($ligne['DateMMYYYY'],-4);
		        }else{
		        	echo "Fiches ".$calendar[substr($ligne['DateMMYYYY'],0,2)].' '.substr($ligne['DateMMYYYY'],-4);
		        }
			}
			else{
				echo "Liste Des Fiches de Frais";
			} ?>
				</h2>
			</div>
			<br>
			<br>
			<?php
				if($_SESSION['IDSelect']==0 && $_SESSION['IDFicheSelect']==0){
				?><div><?php
				include 'include_comptable/Liste.php';
				?></div><?php

			}else if($_SESSION['IDSelect']!=0 && $_SESSION['IDFicheSelect']==0){
				include 'include_comptable/Liste_fiche.php';
			}else if($_SESSION['IDSelect']!=0 && $_SESSION['IDFicheSelect']!=0){
				global $bdd;
			 	$query = $bdd -> prepare('SELECT * FROM forfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
			 	$query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
			 	$query->bindValue('IDFiche',$_SESSION['IDFicheSelect'], PDO::PARAM_STR); 
			 	$query->execute();
			 	$ligne = $query->fetch();
			 	if($ligne!=false){
					include 'include_comptable/Liste_fiche_frais.php';
				}else{
					?>
					<div style="position:absolute;top:60px;font-size:20px;left: 20px;cursor: pointer;" onclick="redirect(this.title);" title='IDFicheSelect'><i class="material-icons" style='font-size:30px;c'>arrow_back</i><span style="position: absolute;top:5px;right:-70px">Retour</span></div>
					<div style='text-align:center;vertical-align: middle;line-height: 180px; font-size:26px'>Pas De Frais Forfaitisé</div>
					<?php
				}	
			}
			?>
	</div>
</div>
<?php 
	if($_SESSION['IDSelect']!=0 && $_SESSION['IDFicheSelect']!=0){
		?>
		<div  class="demo-card-wide mdl-card mdl-shadow--2dp" id="affichage_">
			<?php
			global $bdd;
			 $query = $bdd -> prepare('SELECT * FROM horsforfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
			 $query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
			 $query->bindValue('IDFiche',$_SESSION['IDFicheSelect'], PDO::PARAM_STR); 
			 $query->execute();
			 $ligne = $query->fetch();
			 if($ligne!=false){
				?>
				<div class="mdl-card__title">
					<h2 class="mdl-card__title-text" id="T1">Hors-Forfait</h2>
				</div>
				<br>
				<br>
				<?php
					include 'include_comptable/Liste_fiche_horsfrais.php';
				?>
			</div>
			<?php
		 }else{
		 	?>
			<div  style='text-align:center;vertical-align: middle;line-height: 180px;font-size:26px' >Pas De Frais Hors-Forfait</div>
			<?php
		 }
		?>
</div>
		<?php
	}
?>
</body>
<script src="js/comptable.js"></script>
</html>
<?php
	}else{
		?><i class="material-icons" style="font-size: 160px;position: absolute;left: 280px;top:90px">report_problem</i><div style='font-size: 30;position: absolute;left: 450px;top:150px'>Erreur 404 : Oups Une erreur est survenue<br><br> lors du chargement de la page <a href="index.php" style="color:#e74c3c">>>>ICI<<<</a></div><?php
	}
}else{
	?><i class="material-icons" style="font-size: 160px;position: absolute;left: 280px;top:90px">report_problem</i><div style='font-size: 30;position: absolute;left: 450px;top:150px'>Erreur 404 : Oups Une erreur est survenue<br><br> lors du chargement de la page <a href="index.php" style="color:#e74c3c">>>>ICI<<<</a></div>><?php
}
?>