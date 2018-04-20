var request = false;
var dialog_true = document.getElementById('dialog_true');
var dialog_false = document.getElementById('dialog_false');
$("#submit1").click(function(){
    if(!request){
        request=true;
        var date = $('#date').val();
        var distance = $('#distance').val();
        var repas = $('#repas').val();
        var hotel = $('#hotel').val();
        var IDEmploye = $('#pseudo').val();
        $.ajax({
            type:"post",
            data:{date:date,distance:distance,repas:repas,hotel:hotel,IDEmploye:IDEmploye},
            url:"include_commercial/insert.php",
            error: function () {
                dialog_false.showModal();
                request=false;
             },
            success: function (reponse) {
                dialog_true.showModal();
                request=false;
            }
         })
    }
    return false;
})
$("#uploadimage").on('submit',(function(e) {
    /*for (var pair of form.entries()){
        console.log(pair[0]+', '+pair[1]);
    }
    sleep(10);*/
    $.ajax({
    url: "include_commercial/insert.php", 
    type: "POST",             
    data: new FormData(this), 
    contentType: false,       
    cache: false,             
    processData:false,
    error: function (data) {
            alert("xd");
    },        
    success: function(data)
    {
        alert(data);
    }
})
    }))   
function sleep(seconds){
    var waitUntil = new Date().getTime() + seconds*1000;
    while(new Date().getTime() < waitUntil) true;
}

