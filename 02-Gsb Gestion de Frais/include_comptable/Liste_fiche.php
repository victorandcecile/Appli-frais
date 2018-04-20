<div style="position:absolute;top:60px;font-size:20px;left: 20px;cursor: pointer;" onclick="redirect(this.title);" title='IDSelect'><i class="material-icons" style='font-size:30px'>arrow_back</i><span style="position: absolute;top:5px;right:-70px">Retour</span></div>
<div id="tt4" style="position:absolute;top:15px;right: 55px;cursor: pointer;font-size: 35px;" class="material-icons">contact_phone</i></div>
<div class="mdl-tooltip" for="tt4" style="background-color:#CCC">
	<?php
	global $bdd;
	$query2 = $bdd ->prepare('SELECT * FROM employe WHERE IDEmploye = :IDEmploye');
	$query2->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
	$query2->execute();
	$ligne4 = $query2->fetch();
	if(substr($ligne4['NumTel'],0,2)=='06'){
		echo $ligne4['Prenom'].' '.$ligne4['Nom'].'<br>'.'+(33)'.substr($ligne4['NumTel'],1);
	}else{
		echo $ligne4['Prenom'].' '.$ligne4['Nom'].'<br>'.$ligne4['NumTel'];	
	}
	?>
</div>
<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead >
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh">Date de la fiche</th>
			<th style="color:white;font-size:2.5vh;right:25px;">Forfait</th>
			<th style="right:25px;color: white;font-size:2.5vh">Hors-Forfait</th>
			<th style="right:25px;color: white;font-size:2.5vh">Status</th>
			<th style="right:30px;color: white;font-size:2.5vh">Détail</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 $Distance=0;
		 $Rep=0;
		 $Etp=0;
		 global $bdd;
		 $query = $bdd -> prepare('SELECT * FROM fiche WHERE IDEmploye = :IDEmploye');
		 $query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
		 $query->execute();
		 $date='0';
		 while($ligne = $query->fetch(PDO::FETCH_ASSOC)){
		 	$Date = str_replace('.','/', $ligne['DateMMYYYY']);
		 	if($Date[0]=='0'){
				$date=$Date[1];
			}else{
				$date=$Date;
			}
			$Query = $bdd -> prepare('SELECT COUNT(*) FROM forfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche');
		 	$Query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
		 	$Query->bindValue('IDFiche',$ligne['IDFiche'], PDO::PARAM_STR);
		 	$Query->execute();
		 	$data=$Query->fetch();
		 	$Query2 = $bdd -> prepare('SELECT COUNT(*) FROM horsforfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche');
		 	$Query2->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
		 	$Query2->bindValue('IDFiche',$ligne['IDFiche'], PDO::PARAM_STR);
		 	$Query2->execute();
		 	$data2=$Query2->fetch();
			 
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
			<input type="hidden" id="<?php echo $i.'x';?>" value="<?php echo $ligne['IDFiche'] ?>">
			<td class="mdl-data-table__cell" style="font-size:2.3vh;right:16px" >
			<?php
				echo $Date;
			?>
			</td>
			<td style="right:40px"><?php
				echo $data[0];
			?></td>
			<td style="right:60px">
			<?php
				echo $data2[0];
			?>
			</td>
			<td style="right:15px"><?php
				if($ligne['Actif']==1){
					echo "<i style='color:orange'>En cours</i>";
				}
				else if($ligne['Actif']==0){
					echo "<i style='color:red'>Cloture</i>";
				}
				else{
					echo "<i style='color:green'>Valide</i>";
				}
			?></td>
			<td style="right:36px"><i class="material-icons finds" id="<?php echo $i;?>" style='cursor:pointer'>search</i></td>
		</tr>
	<?php
	}
	?>
	</tbody>
</table>
<dialog class="mdl-dialog" id="dialog_true">
    <h4 class="mdl-dialog__title">Image</h4>
    <div class="mdl-dialog__content">
      <img id="Image" src="">
    </div>
    <div class="mdl-dialog__actions">
      <button type="button" class="mdl-button close">Retour</button>
    </div>
<style>

.mdl-data-table {
  margin:0 auto;
  text-align:center;
}


</style>