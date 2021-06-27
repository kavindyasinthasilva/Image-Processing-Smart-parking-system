<?php

    header("Access-Control-Allow-Origin: *");
    header("Access-Control-Allow-Credentials: true");
    header("Access-Control-Max-Age: 1000");
    header("Access-Control-Allow-Headers: X-Requested-With, Content-Type, Origin, Cache-Control, Pragma, Authorization, Accept, Accept-Encoding");
    header("Access-Control-Allow-Methods: PUT, POST, GET, OPTIONS, DELETE"); 

    include("./connection.php");

    $userEmail = $_GET["email"];
    $userPassword = $_GET["password"];
      $userPassword=md5($userPassword );

    if(!isset($userEmail) || !isset($userPassword)) {
        echo json_encode(
            array(
                'message' => 'error'
            )
        );
    } else {
        $query = "select * from users where email='$userEmail' AND password='$userPassword'";
        $result = mysqli_query($con, $query);
        $array = mysqli_fetch_array($result);
    
        $ID = $array['id'];
       
        $username = $array['username'];
        $email = $array['email'];

        echo json_encode(
            array(
                'id' =>  $ID,
             
                'username' => $username,
                'email' => $email
            )
        );
    }
?>