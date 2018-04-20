  <link rel="stylesheet" href="//fonts.googleapis.com/icon?family=Material+Icons">
  		<link rel="stylesheet" href="https://code.getmdl.io/1.3.0/material.indigo-pink.min.css" />
		<script src="https://storage.googleapis.com/code.getmdl.io/1.0.0/material.min.js"></script>
		<link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
      <link rel="stylesheet" href="css/commercial.css"> 
<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead >
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh">Employe</th>
			<th style="color:white;font-size:2.5vh;right:25px;">Succes</th>
			<th style="right:25px;color: white;font-size:2.5vh">Erreur</th>
			<th style="right:25px;color: white;font-size:2.5vh">% Erreur</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 $bdd = new PDO('mysql:host=localhost;dbname=ppe_prod;charset=utf8', 'root', '');
		 $query = $bdd -> prepare('SELECT * FROM stats_employe');
		 $query->execute();
		 while($ligne = $query->fetch(PDO::FETCH_ASSOC)){		
		 	$query2 = $bdd -> prepare('SELECT Nom FROM employe WHERE IDEmploye = :IDEmploye');
			 $query2->bindValue('IDEmploye',$ligne['IDEmploye'], PDO::PARAM_STR); 
			 $query2->execute();
			 $ligne2=$query2->fetch();	 
	?>
		<?php
			if($i%2==0){
			echo '<tr style="background-color: #EEEEEE;">';
		}
		else{
			echo '<tr style="background-color: #FFFFFF;">';
		}
		$i++;
		?>
		<?php
			for ($cpt2=0; $cpt2<=4;$cpt2++){}
			?>
			<td class="mdl-data-table__cell" style="font-size:2.3vh;right:56px" >
			<?php
				echo $ligne2['Nom'];
			?>
			</td>
			<td style="right:50px"><?php
				echo $ligne['Succes'];
			?></td>
			<td style="right:50px">
			<?php
				echo $ligne['Error'];
			?></td>
			<td style="right:40px">
			<?php
				if($ligne['Error']!=0){
					echo substr(($ligne['Error']/($ligne['Succes']+$ligne['Error'])*100),0,4);
					echo '%';
					echo '<br>';
				}else{
					echo '0%';
					echo '<br>';
				}
			?></td>
		</tr>
	<?php
	}
	?>
	</tbody>
</table>
<div class="mdl-textfield mdl-js-textfield" autocomplete="off" >
          <input class="mdl-textfield__input" id='Euro' name="Euro" >
          <label class="mdl-textfield__label" for="Euro">Text...</label>
 </div>
<style>

.mdl-data-table {
  margin:0 auto;
  text-align:center;
}
..mdl-textfield.is-focused{
	color:black;
}


</style>