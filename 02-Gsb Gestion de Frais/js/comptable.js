var nav1 = document.getElementById('nav1');
var nav2 = document.getElementById('nav2');
var nav3 = document.getElementById('nav3');
var nav4 = document.getElementById('nav4');
var hide2 = document.getElementById('hide2');
var find = document.getElementsByClassName("find");
var finds = document.getElementsByClassName("finds");
var affichage = document.getElementById('affichage');
var affichage_ = document.getElementById('affichage_');
var affichage__ = document.getElementById('affichage__');
var affichage2 = document.getElementById('affichage2');
var affichage2_ = document.getElementById('affichage2_');
var titre = document.getElementById('titre');
var layout = document.getElementById('layout');
for (var i = 0; i < find.length; i++) {
    find[i].addEventListener('click',function(){
	var select = document.getElementById(this.id+'x').value;
	setTimeout(function(){
	window.location.href = "comptable.php?IDSelect="+select;
	layout.className="mdl-layout__drawer";	
    
}, 1);
})
}
for (var i = 0; i < finds.length; i++) {
    finds[i].addEventListener('click',function(){
	var select = document.getElementById(this.id+'x').value;
	setTimeout(function(){
	window.location.href = "comptable.php?IDFicheSelect="+select;
	layout.className="mdl-layout__drawer";	
    
}, 1);
})
}
nav4.addEventListener('click',function(){
	document.location.href="index.php";
})
function redirect(name){
	window.location.href = "comptable.php?"+name+"=0";
}
window.onload = function(){
	var obs = document.getElementsByClassName('mdl-layout__obfuscator');
	obs[0].style.position="fixed";
}