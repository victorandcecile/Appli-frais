
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<link href="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/css/datepicker.min.css" rel="stylesheet" type="text/css">
<link href="css/commercial.css">
<link href="css/style.css">
<script src="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/js/datepicker.min.js"></script>
<script src="js/Fr.js"></script>
<form method="post" enctype="" action="" role="form">
        <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" autocomplete="off">
            <input class="mdl-textfield__input" pattern="[0-9]*" id="hotel">
            <label class="mdl-textfield__label" for="hotel">Hebergement</label>
        </div>
        <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" autocomplete="off">
            <input class="mdl-textfield__input mdl-textfield--floating-label" pattern="[0-9]*" id="repas">
            <label class="mdl-textfield__label" for="repas">Repas</label>
        </div>
        <div class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label" autocomplete="off">
            <input class="mdl-textfield__input" pattern="[0-9]*" id="distance">
            <label class="mdl-textfield__label" for="distance">distance</label>
        </div>
        <br>
        <input id="pseudo" value="<?php echo $_SESSION['IDEmploye']; ?>">
</form>
<script src="js/submit1.js"></script>

