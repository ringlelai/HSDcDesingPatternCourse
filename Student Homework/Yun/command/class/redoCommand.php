<?php

require_once __DIR__.'/iCommand.php';

class redoCommand implements iCommand{
	function excute($input = null){
		$_SESSION['mathCount']++;
		if(!empty($_SESSION['mathResult'][$_SESSION['mathCount']])){
			$result = $_SESSION['mathResult'][$_SESSION['mathCount']];
		}else{
			$result = false;
		}
		
		return $result;
	}
}