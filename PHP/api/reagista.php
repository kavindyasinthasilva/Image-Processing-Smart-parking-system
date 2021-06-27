<?php

    header("Access-Control-Allow-Origin: *");
    header("Access-Control-Allow-Credentials: true");
    header("Access-Control-Max-Age: 1000");
    header("Access-Control-Allow-Headers: X-Requested-With, Content-Type, Origin, Cache-Control, Pragma, Authorization, Accept, Accept-Encoding");
    header("Access-Control-Allow-Methods: PUT, POST, GET, OPTIONS, DELETE");

    include("./connection.php");

    $userEmail = $_GET["email"];
    $userPassword = $_GET["password"];

    if(!isset($userEmail) || !isset($userPassword)) {
        echo json_encode(
            array(
                'message' => 'please enter both email and password.'
            )
        );
    } else {
        $query = "select * from user where email='$userEmail' AND password='$userPassword'";
        $result = mysqli_query($con, $query);
        $rows = mysqli_num_rows($result);
    
        if($rows == 1) {
            echo json_encode(
                array(
                    'message' => 'Login success'
                )
            );
        } else {
            echo json_encode(
                array(
                    'message' => 'Invalid email or password.'
                )
            );
        }
    }