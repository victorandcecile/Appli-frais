var ecran = document.getElementById('Ecran');
var bout = document.getElementById('bout');
var div1 = document.getElementById('div1');
var cp = document.getElementById('champ1');
var log = document.getElementById('log');
var log1 = document.getElementById('log1');
var log_ = document.getElementById('log_');
var log1_ = document.getElementById('log1_');
var bouton = document.getElementById('bout');
log.addEventListener('focus',function(){
  log1.style.top="-20px";
  log1.style.left="-5px";
  log1.style.transform=" scale(.75)";
  log1.style.color="#4a89dc";
})
log.addEventListener('focusout', function () {
  console.log('xd');
  if(log.value!=""){
  }
  else{
    log1.style.top="10px";
    log1.style.left="5px";
    log1.style.transform=" scale(1)";
    log1.style.color="#999";
  }
},false);
log_.addEventListener('focus',function(){
  log1_.style.top="-20px";
  log1_.style.left="-5px";
  log1_.style.transform=" scale(.75)";
  log1_.style.color="#4a89dc";
})
log_.addEventListener('focusout', function () {
  console.log('xd');
  if(log_.value!=""){
  }
  else{
    log1_.style.top="10px";
    log1_.style.left="5px";
    log1_.style.transform=" scale(1)";
    log1_.style.color="#999";
  }
},false)