<?php
  session_start();
  $bdd = new PDO('mysql:host=localhost;dbname=ppe_prod;charset=utf8', 'root', '');
  $bdd->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
if(isset($_POST['iDHorsForfait'])){
  $req = $bdd->prepare("DELETE FROM horsforfait WHERE IDEmploye =:IDEmploye && IDFiche =:IDFiche && IDHorsForfait =:IDHorsForfait");
  $res = $req->execute(array(
            "IDEmploye" => $_POST['iDEmploye'],
            "IDHorsForfait" => $_POST['iDHorsForfait'],
            "IDFiche" => $_POST['iDFiche'],
                ));
  unlink('/wamp/www/Ppe1/upload/'.$_POST['iDEmploye'].'.'.$_POST['iDFiche'].'.'.$_POST['iDHorsForfait'].'.'.$_POST['image']);
} 
if(isset($_POST['IDForfait'])){
  $Repas = filter_input(INPUT_POST,'repas', FILTER_SANITIZE_NUMBER_INT);
    $Hotel = filter_input(INPUT_POST,'hotel', FILTER_SANITIZE_NUMBER_INT);
    $IDEmploye = filter_input(INPUT_POST,'IDEmploye', FILTER_SANITIZE_NUMBER_INT);
    $Distance = filter_input(INPUT_POST,'distance', FILTER_SANITIZE_NUMBER_INT);
    $IDForfait = filter_input(INPUT_POST,'IDForfait', FILTER_SANITIZE_NUMBER_INT);
    if($Repas!='' && $Hotel!='' && $Distance!=''){
      $req = $bdd->prepare("UPDATE forfait SET Repas =:Repas, Etape =:Hotel, Distance =:Distance WHERE IDEmploye =:IDEmploye && Datee =:Datee && IDForfait =:IDForfait");
      $res = $req->execute(array(
            "Datee" => $_POST['date'],
            "Distance" => $Distance,
            "Repas" => $Repas,
            "Hotel" => $Hotel,
            "IDEmploye" => $IDEmploye,
            "IDForfait" => $IDForfait
                ));
            echo '0';
      }else{
        echo 'Spécifier tous les champs et vérifier leur format';
        return;
      }

}
else if(isset($_POST['date'])){
    $Repas = filter_input(INPUT_POST,'repas', FILTER_SANITIZE_NUMBER_INT);
    $Hotel = filter_input(INPUT_POST,'hotel', FILTER_SANITIZE_NUMBER_INT);
    $IDEmploye = filter_input(INPUT_POST,'IDEmploye', FILTER_SANITIZE_NUMBER_INT);
    $Distance = filter_input(INPUT_POST,'distance', FILTER_SANITIZE_NUMBER_INT);
    if(preg_match("#^[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]$#", $_POST['date']) && $Repas!='' && $Hotel!='' && $Distance!=''){
      $Date=str_replace('.','/', $_POST['date']);
      $Query = $bdd->prepare("SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && Actif=1");
      $Query->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
      $Query->execute();
      $data=$Query->fetch();
      try {
          $req = $bdd->prepare("INSERT INTO forfait ( Datee, Distance, Repas, Etape, IDEmploye, IDFiche) VALUES ( :Datee, :Distance, :Repas, :Hotel, :IDEmploye, :IDFiche)");
          $res = $req->execute(array(
                "Datee" => $Date,
                "Distance" => $Distance,
                "Repas" => $Repas,
                "Hotel" => $Hotel,
                "IDEmploye" => $IDEmploye,
                "IDFiche" => $data['IDFiche']
                ));
            echo 'enregistrement reussit';
          
        } catch (PDOException $e) {
            echo 'Oups!!';
        }
      }else{
        echo 'Spécifier tous les champs et vérifier leur format';
        return;
      }
  }
if(isset($_FILES['file']['type']) && isset($_POST['Description']) && isset($_POST['Date_h']) && isset($_POST['Euro']) && isset($_POST['IDEmploye'])){
    if($_FILES['file']['type']=='' || $_POST['Description']=='' || !preg_match("#^[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]$#", $_POST['Date_h']) || $_POST['Euro']=''){
      echo "Veuillez remplir tout les champs svp";
      return;
    }
    $Date = preg_replace("([^0-9.])","",$_POST['Date_h']);
    if($Date==$_POST['Date_h']){
      $Date=str_replace('.','/', $Date);
      $validextensions = array("jpeg", "jpg", "png");
      $temporary = explode(".", $_FILES["file"]["name"]);
      $file_extension = end($temporary);
      if ((($_FILES["file"]["type"] == "image/png") || ($_FILES["file"]["type"] == "image/jpg") || ($_FILES["file"]["type"] == "image/jpeg")) && ($_FILES["file"]["size"] < 1000000) && in_array($file_extension, $validextensions)) {
      if ($_FILES["file"]["error"] > 0){
        echo 'Mauvais Format ou taille incorecte';
        return;
      }
      else{
        $Description = filter_input(INPUT_POST,'Description', FILTER_SANITIZE_STRING);
        $Euro = filter_input(INPUT_POST,'Euro', FILTER_SANITIZE_NUMBER_INT);
        $IDEmploye = filter_input(INPUT_POST,'IDEmploye', FILTER_SANITIZE_NUMBER_INT);
        $Query = $bdd->prepare("SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && Actif=1");
        $Query->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
        $Query->execute();
        $data=$Query->fetch();
        try {
          $req = $bdd->prepare("INSERT INTO horsforfait ( Datee, Image, Description, Montant, Status, IDEmploye, IDFiche) VALUES ( :Datee, :Image, :Description, :Montant, :Status, :IDEmploye, :IDFiche)");
          $res = $req->execute(array(
                "Datee" => $Date,
                "Image" => $_FILES["file"]["name"],
                "Description" => $Description,
                "Montant" => $Euro,
                "Status" => 1,
                "IDEmploye" => $IDEmploye,
                "IDFiche" => $data['IDFiche']
                ));
          try{
            $sourcePath = $_FILES['file']['tmp_name']; 
            $_FILES['file']['name'] = $_SESSION['IDEmploye'].'.'.$data['IDFiche'].'.'.$bdd->lastinsertid().'.'.$_FILES['file']['name'];
            $targetPath = "/wamp/www/Ppe1/upload/".$_FILES['file']['name']; 
            move_uploaded_file($sourcePath,$targetPath) ;
            echo "enregistrement ajoute";
          }catch (PDOException $e){
            echo "enregistrement ajoute";
          }
          
        } catch (PDOException $e) {
          echo 'Oups!!';
          return;
        }
      }
      
    }
  } 
}
      
?>