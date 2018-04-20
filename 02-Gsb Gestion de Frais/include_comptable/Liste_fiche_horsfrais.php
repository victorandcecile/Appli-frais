<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp">
	<thead>
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh;">Date</th>
			<th style="right:5px;color: white;font-size:2.5vh">Description</th>
			<th style="right:25px;color: white;font-size:2.5vh ">Justificatif</th>
			<th style="right:30px;color: white;font-size:2.5vh ">Montant</th>
			<th style="right:35px;color: white;font-size:2.5vh">Action</th>
		</tr>
	</thead>
	<tbody>
	<?php 
		 $i=0;
		 global $bdd;
		 $query = $bdd -> prepare('SELECT * FROM horsforfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
		 $query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
		 $query->bindValue('IDFiche',$_SESSION['IDFicheSelect'], PDO::PARAM_STR); 
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
			<td class="mdl-data-table__cell" style="font-size:2.3vh;left:5px">
			<?php
				echo $Date;
			?>
			</td>
			<td style="right:30px;">
			<?php
				echo $ligne['Description'];
			?>
			</td>
			<td style="right:20px;cursor: pointer;color:green" class="justificatif" title="<?php echo "upload/".$ligne['IDEmploye'].'.'.$ligne['IDFiche'].'.'.$ligne['IDHorsForfait'].'.'.$ligne['Image']?>">Voir le justificatif
				<input type="hidden" value="<?php echo $ligne['Image'];?>"></td>
			<td style="right:40px"><?php
				echo $ligne['Montant'].'$';
			?></td>
			<td id="<?php echo $i ?>" style="right:45px;" class="supprimer">
				<i class="material-icons" style="cursor:pointer;" title="Supprimer">delete</i>
				<input type="hidden" value="<?php echo $ligne['IDEmploye']?>">
				<input type="hidden" value="<?php echo $ligne['IDFiche']?>">
				<input type="hidden" value="<?php echo $ligne['IDHorsForfait']?>">
				<input type="hidden" value="<?php echo $ligne['Image']?>">
			</td>
		</tr>
	<?php
	}
	?>
	</tbody>
</table>
<button class="Bouton">Valider la fiche</button>
</div>
<dialog class="mdl-dialog" id="dialog_trues">
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
</style>
</style>
<script type="text/javascript">
var justificatif = document.getElementsByClassName("justificatif");
var image = document.getElementById("Image");
var titleImg = document.getElementById("titleImg");
var dialog_trues = document.getElementById('dialog_trues');
var supprimer = document.getElementsByClassName("supprimer");
if (! dialog_trues.showModal) {
      dialogPolyfill.registerDialog(dialog_trues);
    }
console.log(justificatif);
for (var y = 0; y < justificatif.length; y++) {
    justificatif[y].addEventListener('click',function(){
    	image.src=this.title;;
    	titleImg.innerHTML = this.children[0].value;
    	dialog_trues.showModal();
	});
}
dialog_trues.querySelector('.close').addEventListener('click', function() {
      dialog_trues.close();
    });
var request = false;
for(var i=0; i<supprimer.length;i++){
	supprimer[i].addEventListener('click',function(){
		if(!request){
			var request = true;
			iDEmploye = this.children[1].value;
			iDFiche = this.children[2].value;
			iDHorsForfait = this.children[3].value;
			image = this.children[4].value;
			 $.ajax({
	            type:"post",
	            data:{iDEmploye:iDEmploye,iDFiche:iDFiche,iDHorsForfait:iDHorsForfait,image:image},
	            url:"include_commercial/insert.php",
	            error: function () {
	            	request=false;
	             },
	            success: function (reponse) {
	                request=false;
	                window.location.href = "comptable.php";
	            }
	         })
	     }
	})
}
</script>