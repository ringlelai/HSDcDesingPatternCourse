<?php

require_once __DIR__.'/commnadCall.php';

session_start();

if(empty($_SESSION['mathCount'])){
	$_SESSION['mathCount'] = 0;
}

if(empty($_SESSION['mathResult'])){
	$_SESSION['mathResult'] = array();
}

if(empty($_POST['calString'])){
	$calString = null;
}else{
	$calString = $_POST['calString']; 
}
if(!empty($_POST['calCommand'])){
	$Cal = new commnadCall();
	echo $Cal->useCommnad($_POST['calCommand'], $calString);	
}