<?php

$name = "studmysql01.fhict.local";
$user = "dbi358097";
$pass = "12344321";
$db = "dbi358097";

try {
    if ($conn = mysqli_connect($name, $user, $pass, $db)) {
        echo "connection successful";
    }
    else
    {
        throw new Exception('Unable to connect');
    }
}
catch(Exception $e)
{
    echo $e->getMessage();
}