<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead >
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh">Nom</th>
			<th style="color:white;font-size:2.5vh;right:25px;">Prenom</th>
			<th style="right:25px;color: white;font-size:2.5vh">Nb de Fiche</th>
			<th style="right:30px;color: white;font-size:2.5vh">Voir les Fiches</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 $Distance=0;
		 $Rep=0;
		 $Etp=0;
		 global $bdd;
		 $query = $bdd -> prepare('SELECT * FROM employe WHERE TypeDeConnexion = 0'); 
		 $query->execute();
		 $date='0';
		 while($ligne = $query->fetch(PDO::FETCH_ASSOC)){
			$Query = $bdd -> prepare('SELECT COUNT(*) FROM fiche WHERE IDEmploye = :IDEmploye');
		 	$Query->bindValue('IDEmploye',$ligne['IDEmploye'], PDO::PARAM_STR); 
		 	$Query->execute();
		 	$data=$Query->fetch();
			 
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
			<input type='hidden' id="<?php echo $i.'x';?>" value="<?php echo $ligne['IDEmploye']?>">
			<td class="mdl-data-table__cell" style="font-size:2.3vh;right:25px" >
			<?php
				echo $ligne['Nom'];
			?>
			</td>
			<td style="right:30px"><?php
				echo $ligne['Prenom'];
			?></td>
			<td style="right:60px">
			<?php
				echo $data[0];
			?>
			</td>
			<td style="right:65px">
				<i class="material-icons find" id="<?php echo $i;?>" style='cursor:pointer'>visibility</i>
			</td>
		</tr>
	<?php
	}
	?>
	</tbody>
</table>
<style>

.mdl-data-table {
  margin:0 auto;
  text-align:center;
  margin-bottom: 30px;
}


</style>