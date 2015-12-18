<?php

require_once __DIR__ . '/redoCommand.php';
require_once __DIR__ . '/undoCommand.php';
require_once __DIR__ . '/calculateCommand.php';

class commnadCall{
	function __construct(){}
	function useCommnad($command,$input = null){
		$compute = new $command();
		return $compute->excute($input);
	}
}