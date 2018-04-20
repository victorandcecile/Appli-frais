<?php include 'config.php'; ?>
<?php
  global $bdd;
  if(isset($_POST['submit']))
  {
        $query = $bdd -> prepare('SELECT MotDePasse,IDEmploye,Pseudo,TypeDeConnexion FROM employe WHERE Pseudo = :Pseudo'); 
        $query->bindValue(':Pseudo',$_POST['psd'], PDO::PARAM_STR); //redefinir une variable
        $query->execute();
        $data=$query->fetch();
        if($data['TypeDeConnexion'] == 0){
          $_SESSION['TypeDeConnexion'] == 0;
          if($data['Pseudo'] == $_POST['psd']){
            $_SESSION['IDEmploye']=$data['IDEmploye'];
            if($data['MotDePasse'] == $_POST['mdp'])
            {
              $query2 = $bdd -> prepare('SELECT DateMMYYYY FROM fiche WHERE IDEmploye = :IDEmploye'); 
              $query2->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $query2->execute();
              $ligne=$query2->fetch();
              $Flag=0;
              $Date=date("m.20y");
              if($ligne['DateMMYYYY']==$Date){
                $Flag=1;
              }
              while($ligne = $query2->fetch(PDO::FETCH_ASSOC)){
                echo $Date.':'.$ligne['DateMMYYYY'];
                if($Date==$ligne['DateMMYYYY']){
                  $Flag=1;
                  break;
                }
              }
              if(!$Flag){
                $query4 = $bdd -> prepare('UPDATE fiche SET Actif=0 WHERE IDEmploye =:IDEmploye && Actif<2'); 
                $query4->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
                $query4->execute();
                $query3 = $bdd -> prepare('INSERT INTO fiche SET DateMMYYYY =:DateMMYYYY,IDEmploye =:IDEmploye'); 
                $query3->bindValue(':DateMMYYYY',$Date, PDO::PARAM_STR); //redefinir une variable
                $query3->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
                $query3->execute();
              }
              $Query = $bdd->prepare("SELECT IDFiche FROM fiche WHERE IDEmploye = :IDEmploye && Actif=1");
              $Query->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $Query->execute();
              $data2=$Query->fetch();
              $_SESSION['IDFiche']=$data2['IDFiche'];
              $_SESSION['Date']=$Date;
              //PPE_add///
              $Query2 = $bdd->prepare("SELECT Succes FROM stats_employe WHERE IDEmploye = :IDEmploye");
              $Query2->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $Query2->execute();
              $data3=$Query2->fetch();
              $Query3 = $bdd -> prepare('UPDATE stats_employe SET Succes =:Succes WHERE IDEmploye =:IDEmploye'); 
              $Query3->bindValue(':Succes',$data3['Succes']+1, PDO::PARAM_INT); //redefinir une variable
              $Query3->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $Query3->execute();
              $_SESSION['TypeDeConnexion'] = 0;
              /////////////
              header('Location: commercial.php');
            }
            ///PPE_add//
            else{
              $Query2 = $bdd->prepare("SELECT Error FROM stats_employe WHERE IDEmploye = :IDEmploye");
              $Query2->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $Query2->execute();
              $data2=$Query2->fetch();
              $Query3 = $bdd -> prepare('UPDATE stats_employe SET Error =:Error WHERE IDEmploye =:IDEmploye'); 
              $Query3->bindValue(':Error',$data2['Error']+1, PDO::PARAM_INT); //redefinir une variable
              $Query3->bindValue(':IDEmploye',$_SESSION['IDEmploye'], PDO::PARAM_INT); //redefinir une variable
              $Query3->execute();
            }
            ////////////
          }
        }else{
          if($data['Pseudo'] == $_POST['psd'] && $data['MotDePasse'] == $_POST['mdp']){
            $_SESSION['IDEmploye']=$data['IDEmploye'];
            $_SESSION['TypeDeConnexion'] = 1;
            $_SESSION['IDFicheSelect'] = 0;
            $_SESSION['IDSelect'] = 0;
            header('Location: comptable.php');
          }
        }       
  }
?>