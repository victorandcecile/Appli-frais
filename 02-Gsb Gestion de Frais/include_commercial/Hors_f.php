<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead>
		<tr style="background-color: #4a89dc;">
			<th style="right:5px;color: white;font-size:2.5vh;text-align: center;">Description</th>
			<th style="right:45px;color: white;font-size:2.5vh;text-align: center; ">Justificatif</th>
			<th style="right:30px;color: white;font-size:2.5vh;text-align: center; ">Montant</th>
			<th style="right:35px;color: white;font-size:2.5vh;text-align: center;">Etat</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 global $bdd;
		 $Query = $bdd -> prepare('SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && DATEMMYYYY = :DATEMMYYYY');
		 $Query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
		 $Query->bindValue('DATEMMYYYY',$_SESSION['Date'], PDO::PARAM_STR); 
		 $Query->execute();
		 $data2=$Query->fetch();
		 $query = $bdd -> prepare('SELECT * FROM horsforfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
		 $query->bindValue('IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_STR); 
		 $query->bindValue('IDFiche',$data2['IDFiche'], PDO::PARAM_STR); 
		 $query->execute();
		 while($ligne = $query->fetch(PDO::FETCH_ASSOC)){
		 	$Date = str_replace('-','/', $ligne['Datee']);
	?>
		<?php
			if($i%2==0){
			echo '<tr style="background-color: #EEEEEE">';
		}
		else{
			echo '<tr style="background-color: #FFFFFF;">';
		}
		$i++;
		?>
		<?php
			for ($cpt2=0; $cpt2<=4;$cpt2++){}
			?>
			<td style="right:30px;">
			<?php
				echo $ligne['Description'];
			?>
			</td>
			<td style="right:25px;cursor: pointer;text-align: center;color:green" class="justificatif" title="<?php echo "upload/".$ligne['IDEmploye'].'.'.$ligne['IDFiche'].'.'.$ligne['IDHorsForfait'].'.'.$ligne['Image']?>">Voir le justificatif<input type="hidden" value="<?php echo$ligne['Image'];?>"></td>
			<td style="right:40px;text-align: center;"><?php
				echo $ligne['Montant'].'$';
			?></td>
			<td style="left:-25px;text-align: center;"><?php
				if($ligne['Status']==1){
					echo '<i style="color:orange">En cours</i>';
				}
				if($ligne['Status']==0){
					echo '<i style="color:green">Valide</i>';
				}
				if($ligne['Status']==2){
					echo '<i style="color:red">Refuse</i>';
				}
			?></td>
		</tr>
	<?php
	$_SESSION['Date']=date('m.20y');
	}
	?>
	</tbody>
</table>
</div>
<dialog class="mdl-dialog" id="dialog_true">
    <h4 class="mdl-dialog__title" id="titleImg">Image</h4>
    <div class="mdl-dialog__content">
      <img id="Image" src="">
    </div>
    <div class="mdl-dialog__actions">
      <button type="button" class="mdl-button close">Retour</button>
    </div>
</dialog>
<style>
.overlay {
    background-color: rgba(1, 1, 1, 0.7);
    bottom: 0;
    left: 0;
    position: fixed;
    right: 0;
    top: 0;
}
.mdl-data-table {
  margin:0 auto;
  text-align:center;
}
</style>
<script type="text/javascript">
var justificatif = document.getElementsByClassName("justificatif");
var image = document.getElementById("Image");
var titleImg = document.getElementById("titleImg");
var dialog_true = document.getElementById('dialog_true');
if (! dialog_true.showModal) {
      dialogPolyfill.registerDialog(dialog_true);
    }
console.log(justificatif);
for (var y = 0; y < justificatif.length; y++) {
    justificatif[y].addEventListener('click',function(){
    	image.src=this.title;
    	titleImg.innerHTML = this.children[0].value;
    	dialog_true.showModal();
	});
}
dialog_true.querySelector('.close').addEventListener('click', function() {
      dialog_true.close();
    });
</script>