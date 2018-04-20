var nav1 = document.getElementById('nav1');
var nav2 = document.getElementById('nav2');
var nav3 = document.getElementById('nav3');
var nav4 = document.getElementById('nav4');
var hide = document.getElementById('hide');
var hide2 = document.getElementById('hide2');
var find = document.getElementsByClassName("find");
var affichage = document.getElementById('affichage');
var affichage_ = document.getElementById('affichage_');
var affichage__ = document.getElementById('affichage__');
var affichage2 = document.getElementById('affichage3');
var affichage2_ = document.getElementById('affichage2_');
var titre = document.getElementById('titre');
var layout = document.getElementById('layout');
nav2.addEventListener('click',function(){
	hide.value = "Fiche "+formatDate(new Date());
	titre.innerHTML = 'Ajouter des Frais '+formatDate(new Date());
	affichage.style.display="none";
	affichage_.style.display="none";
	affichage__.style.display="none";
	affichage3.style.display="inline-block";
	affichage2_.style.display="inline-block";
	layout.className="mdl-layout__drawer";
});
nav1.addEventListener('click',function(){
	window.location.href = "commercial.php?Date="+hide2.value;
	titre.innerHTML = hide.value;
	affichage.style.display="inline-block";
	affichage_.style.display="inline-block";
	affichage__.style.display="none";
	affichage3.style.display="none";
	affichage2_.style.display="none";
	layout.className="mdl-layout__drawer";
})
nav3.addEventListener('click',function(){
	titre.innerHTML= 'Historique';
	affichage.style.display="none";
	affichage_.style.display="none";
	affichage__.style.display="inline-block";
	affichage3.style.display="none";
	affichage2_.style.display="none";
	layout.className="mdl-layout__drawer";
})
for (var i = 0; i < find.length; i++) {
    find[i].addEventListener('click',function(){
	titre.innerHTML = hide.value;
	alert(document.getElementById(this.id+'x').value);
	var date = document.getElementById(this.id+'x').value;
	window.location.href = "commercial.php?Date="+date;
	affichage.style.display="inline-block";
	affichage_.style.display="inline-block";
	affichage__.style.display="none";
	affichage3.style.display="none";
	affichage2_.style.display="none";
	layout.className="mdl-layout__drawer";	
    
})
}
nav4.addEventListener('click',function(){
	document.location.href="index.php";
})

window.onload = function(){
	var obs = document.getElementsByClassName('mdl-layout__obfuscator');
	obs[0].style.position="fixed";
}
function formatDate(date) {
  var monthNames = [
    "de Janvier", "de Fevrier", "de Mars",
    "d'Avril", "de Main", "de Juin", "de Juillet",
    "d'Aout", "de Septembre", "d'Octobre",
    "de Novembre", "de Decembre"
  ];
  var monthIndex = date.getMonth();
  var year = date.getFullYear();

  return monthNames[monthIndex] + ' ' + year;
}