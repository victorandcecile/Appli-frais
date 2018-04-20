<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead >
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh">Date</th>
			<th style="color:white;font-size:2.5vh;right:25px;">Durée</th>
			<th style="right:25px;color: white;font-size:2.5vh">Etape</th>
			<th style="right:25px;color: white;font-size:2.5vh">Repas</th>
			<th style="right:30px;color: white;font-size:2.5vh">Distance</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 $Distance=0;
		 $Rep=0;
		 $Etp=0;
		 $Duree=0;
		 global $bdd;
		 $Query = $bdd -> prepare('SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && DATEMMYYYY = :DATEMMYYYY');
		 $Query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
		 $Query->bindValue('DATEMMYYYY',$_SESSION['Date'], PDO::PARAM_STR); 
		 $Query->execute();
		 $data2=$Query->fetch();
		 $query = $bdd -> prepare('SELECT * FROM forfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
		 $query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
		 $query->bindValue('IDFiche',$data2['IDFiche'], PDO::PARAM_STR); 
		 $query->execute();
		 while($ligne = $query->fetch(PDO::FETCH_ASSOC)){
		 	$Date = str_replace('-','/', $ligne['Datee']);
		 	$Distance+=$ligne['Distance'];
		 	$Rep+=$ligne['Repas'];
		 	$Etp+=$ligne['Etape'];
		 	$Duree+=$ligne['Duree'];
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
			<td class="mdl-data-table__cell" style="font-size:2.3vh;right:16px">
			<?php
				echo $Date;
			?>
			</td>
			<td style="right:40px"><?php
				echo $ligne['Duree'].'j';
			?></td>
			<td style="right:40px">
			<?php
				echo $ligne['Etape'];
			?>
			</td>
			<td style="right:40px"><?php
				echo $ligne['Repas'];
			?></td>
			<td style="right:40px"><?php
				echo $ligne['Distance'].'km';
			?></td>
		</tr>
	<?php
	}
	?>
		<?php
			if($i%2==0){
			echo '<tr style="background-color: #EEEEEE;">';
		}
		else{
			echo '<tr style="background-color: #FFFFFF;">';
		}
		?>
			<td class="mdl-data-table__cell" style="color: black;font-weight: 700;right:35px">Total</td>
			<td style="font-size: 2.5vh;color: black;font-weight: 700;right:38px">
				<?php
				echo $Duree.'j';
				?>
			</td>
			<td style="font-size: 2.5vh;color: black;font-weight: 700;right:38px">
				<?php
				echo $Etp;
				?>
			</td>
			<td style="font-size: 2.5vh;color: black;font-weight: 700;right:38px">
				<?php
				echo $Rep;
				?>
			</td>
			<td style="font-size: 2.5vh;color: black;font-weight: 700;right:36px">
				<?php
				echo $Distance.'km';
				?>
			</td>
		</tr>
	</tbody>
</table>
<style>

.mdl-data-table {
  margin:0 auto;
  text-align:center;
}




</style>