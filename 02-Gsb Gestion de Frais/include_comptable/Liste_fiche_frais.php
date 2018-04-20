<div style="position:absolute;top:60px;font-size:20px;left: 20px;cursor: pointer;" onclick="redirect(this.title);" title='IDFicheSelect'><i class="material-icons" style='font-size:30px;c'>arrow_back</i><span style="position: absolute;top:5px;right:-70px">Retour</span></div>
<table class="mdl-data-table mdl-js-data-table mdl-data-table mdl-shadow--2dp" style="width:45vw">
	<thead >
		<tr style="background-color: #4a89dc;">
			<th class="mdl-data-table__cell--non-numeric" style="left:16px;color: white;font-size:2.5vh">Date</th>
			<th style="color:white;font-size:2.5vh;right:25px;">Durée</th>
			<th style="right:25px;color: white;font-size:2.5vh">Etape</th>
			<th style="right:25px;color: white;font-size:2.5vh">Repas</th>
			<th style="right:30px;color: white;font-size:2.5vh">Distance</th>
			<th style="right:30px;color: white;font-size:2.5vh">Action</th>
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
		 $query = $bdd -> prepare('SELECT * FROM forfait WHERE IDEmploye = :IDEmploye && IDFiche = :IDFiche ORDER BY Datee');
		 $query->bindValue('IDEmploye',$_SESSION['IDSelect'], PDO::PARAM_STR); 
		 $query->bindValue('IDFiche',$_SESSION['IDFicheSelect'], PDO::PARAM_STR); 
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
			<td class="mdl-data-table__cell abc" style="font-size:2.3vh;right:16px">
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
			<td style="right:40px;cursor:pointer;" title="Modifier" class="modif">
				<input type="hidden" value="<?php echo $Date;?>">
				<input type="hidden" value="<?php echo $ligne['Etape'];?>">
				<input type="hidden" value="<?php echo $ligne['Repas'];?>">
				<input type="hidden" value="<?php echo $ligne['Distance'];?>">
				<input type="hidden" value="<?php echo $ligne['IDForfait'];?>">
				<i class="material-icons">update</i>
			</td>
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
			<td></td>
		</tr>
	</tbody>
</table>
<input type="hidden" value="<?php echo $_SESSION['IDSelect'];?>" id="utilisateur">
<dialog class="mdl-dialog" id="dialog_true">
    <h4 class="mdl-dialog__title" id="titleDate">Date</h4>
    <div class="mdl-dialog__content">
      <br>
	  <br>
			<?php
				include 'include_comptable/aff_f.php';
			?>
    </div>
    <input type="hidden" id="IDForfait">
    <div class="mdl-dialog__actions">
    	<button id="submit1" type="submit" name="upload" value="Valider" class="mdl-button mdl-js-button mdl-button--fab" style="height:56px"><i class="material-icons">done</i></button>
        <button  class="mdl-button mdl-js-button mdl-button--fab close" id="bouton_cancel" style="height:56px"><i class="material-icons">close</i></button>
    </div>
</dialog>
<div id="snackbar">update</div>
<style>
.mdl-snackbar {
  background-color: rgba(46, 204, 113, .95);
}

.mdl-snackbar__icon {
  color: #ffffff;
  padding: 13px 0 0 24px;
}

.mdl-snackbar__action {
  color: #ffffff;
}
#snackbar {
    visibility: hidden;
    min-width: 250px;
    margin-left: -125px;
    background-color: #333;
    color: #4CAF50;
    border-radius: 2px;
    padding: 16px;
    position: fixed;
    z-index: 1;
    left: 50%;
    bottom: 30px;
    font-size: 17px;
}

#snackbar.show {
    visibility: visible;
    -webkit-animation: fadein 0.5s, fadeout 0.5s 2.5s;
    animation: fadein 0.5s, fadeout 0.5s 2.5s;
}

@-webkit-keyframes fadein {
    from {bottom: 0; opacity: 0;} 
    to {bottom: 30px; opacity: 1;}
}

@keyframes fadein {
    from {bottom: 0; opacity: 0;}
    to {bottom: 30px; opacity: 1;}
}

@-webkit-keyframes fadeout {
    from {bottom: 30px; opacity: 1;} 
    to {bottom: 0; opacity: 0;}
}

@keyframes fadeout {
    from {bottom: 30px; opacity: 1;}
    to {bottom: 0; opacity: 0;}
}
</style>
<script type="text/javascript">
var modif = document.getElementsByClassName("modif");
var dialog_true = document.getElementById('dialog_true');
var titleDate = document.getElementById("titleDate");
var hotel = document.getElementById("hotel");
var repas = document.getElementById("repas");
var distance = document.getElementById("distance");
var iDForfait = document.getElementById("IDForfait");
var snackbarContainer = document.querySelector('.mdl-js-snackbar');
if (! dialog_true.showModal) {
      dialogPolyfill.registerDialog(dialog_true);
    }
for (var y = 0; y < modif.length; y++) {
    modif[y].addEventListener('click',function(){
    	titleDate.innerHTML = this.children[0].value;
    	repas.value = this.children[2].value;
    	distance.value = this.children[3].value;
    	hotel.value = this.children[1].value;
    	iDForfait.value = this.children[4].value;
    	hotel.parentElement.classList.add("is-dirty");
    	distance.parentElement.classList.add("is-dirty");
    	repas.parentElement.classList.add("is-dirty");
    	dialog_true.showModal();
	});
}
dialog_true.querySelector('.close').addEventListener('click', function() {
      dialog_true.close();
});
function Show() {
    var x = document.getElementById("snackbar");
    x.className = "show";
    setTimeout(function(){ x.className = x.className.replace("show", "");window.location.href = "comptable.php"; }, 3000);
}
var request = false;
$("#submit1").click(function(){
    if(!request){
        request=true;
        var date_ = titleDate.innerHTML;
        var distance_ = distance.value;
        var repas_ = repas.value;
        var hotel_ = hotel.value;
        var IDEmploye_ = $('#utilisateur').val();
        var IDForfait_ = iDForfait.value;
        $.ajax({
            type:"post",
            data:{date:date_,distance:distance_,repas:repas_,hotel:hotel_,IDEmploye:IDEmploye_,IDForfait:IDForfait_},
            url:"include_commercial/insert.php",
            error: function () {
            	var x = document.getElementById("snackbar");
   				x.innerHTML =  "Erreur de modification";
   				x.style.color = "#F44336";
                request=false;
             },
            success: function (reponse) {
                request=false;
                var x = document.getElementById("snackbar");
                if(reponse==0){
	   				x.innerHTML =  "Frais du "+date_+" modifié";
	   				x.style.color = "#4CAF50";
	   			}else{
	   				x.innerHTML =  "Erreur de modification";
   					x.style.color = "#F44336";
	   			}
                dialog_true.close();
                Show();
            }
         })
    }
    return false;
})
</script>