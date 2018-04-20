
<script type="text/javascript" src="http://code.jquery.com/jquery-1.7.2.min.js"></script>
<link href="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/css/datepicker.min.css" rel="stylesheet" type="text/css">
<script src="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/js/datepicker.min.js"></script>
<form method="post" enctype="multipart/form-data" content="charset=utf-8" action="" role="form" id="uploadimage">
        <input id="pseudo" value="<?php echo $_SESSION['IDEmploye']; ?>" name="IDEmploye">
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off" style="position: relative;"> 
          <input type='text' class="datepicker-here mdl-textfield__input" data-position="right top" id="Date_h" name="Date_h">
          <label class="mdl-textfield__label" for="Date_h">Date</label>
        </div>
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off">
          <input class="mdl-textfield__input" pattern="[0-9]*" id='Euro' name="Euro">
          <label class="mdl-textfield__label" for="Euro">Euro</label>
          <span class="mdl-textfield__error">Pas de lettres</span>
        </div>
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off">
          <textarea class="mdl-textfield__input" type="text" rows= "3" id="Description" name="Description"></textarea>
          <label class="mdl-textfield__label" for="Description">Description</label>
        </div>
        <div class="file_input_div">
          <div class="file_input">
            <label class="image_input_button mdl-button mdl-js-button mdl-button--fab mdl-button--mini-fab mdl-js-ripple-effect mdl-button--colored color" style="background-color: #727272;">
            <i class="material-icons">file_upload</i>
            <input id="file_input_file" name="file" class="none" type='file'>
            </label>
          </div>
          <div id="file_input_text_div" class="mdl-textfield mdl-js-textfield textfield-demo">
            <input name='texte' class="file_input_text mdl-textfield__input" id="file_input_text" readonly disabled>
            <label class="mdl-textfield__label" for="file_input_text"></label>
          </div>
        </div>
         <button id="submit2" type="submit" name="upload" value="Valider" class="mdl-button mdl-js-button mdl-button--fab "><i class="material-icons">done</i></button>
       
</form>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script src="js/submit1.js"></script>
<script src="js/upload.js"></script>