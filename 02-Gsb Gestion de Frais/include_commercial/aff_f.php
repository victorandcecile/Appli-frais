
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<link href="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/css/datepicker.min.css" rel="stylesheet" type="text/css">
<link href="css/commercial.css">
<link href="css/style.css">
<script src="https://cdnjs.cloudflare.com/ajax/libs/air-datepicker/2.2.3/js/datepicker.min.js"></script>
<script src="js/Fr.js"></script>
<form method="post" enctype="" action="" role="form">
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off">
            <input class="mdl-textfield__input" pattern="[0-9]*" id="hotel">
            <label class="mdl-textfield__label" for="hotel">Hebergement</label>
            <span class="mdl-textfield__error">Pas de lettres</span>
        </div>
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off">
            <input class="mdl-textfield__input" pattern="[0-9]*" id="repas">
            <label class="mdl-textfield__label" for="repas">Repas</label>
            <span class="mdl-textfield__error">Pas de lettres</span>
        </div>
        <div class="mdl-textfield mdl-js-textfield" autocomplete="off">
            <input class="mdl-textfield__input" pattern="[0-9]*" id="distance">
            <label class="mdl-textfield__label" for="distance">distance</label>
            <span class="mdl-textfield__error">Pas de lettres</span>
        </div>
        <br>
        <button  type="submit" name="upload" value="Valider" class="mdl-button mdl-js-button mdl-button--fab top"><i class="material-icons">done</i></button>
        <input id="pseudo" value="<?php echo $_SESSION['IDEmploye']; ?>">
</form>
<dialog class="mdl-dialog" id="dialog_true">
    <h4 class="mdl-dialog__title">Valide</h4>
    <div class="mdl-dialog__content">
      <p>
        Frais Ajouté
      </p>
    </div>
    <div class="mdl-dialog__actions">
      <button type="button" class="mdl-button close">Ok</button>
    </div>
  </dialog>
<dialog class="mdl-dialog" id="dialog_false">
    <h4 class="mdl-dialog__title">Erreur</h4>
    <div class="mdl-dialog__content">
      <p>
        Une erreur est survenue vérifiez vos inputs
      </p>
    </div>
    <div class="mdl-dialog__actions">
      <button type="button" class="mdl-button close">Ok</button>
    </div>
  </dialog>
<script src="js/submit1.js"></script>
<script type="text/javascript">
    var dialog_true = document.getElementById('dialog_true');
    var dialog_false = document.getElementById('dialog_false');
    if (! dialog_true.showModal) {
      dialogPolyfill.registerDialog(dialog_true);
    }
    if (! dialog_false.showModal) {
      dialogPolyfill.registerDialog(dialog_false);
    }
    dialog_true.querySelector('.close').addEventListener('click', function() {
      dialog_true.close();
    });
    dialog_false.querySelector('.close').addEventListener('click', function() {
      dialog_false.close();
    });
  </script>
</script>

