<?php

require_once 'remoteGetRoom.php';

class proxyRoom{
	protected static $cachedRoom = array();
	protected static $count = 0;
	private function __construct(){}
	public static function getRoomObject(){
		if(empty(static::$cachedRoom)){
			$remote = new remoteGetRoom();
			$remoteRoom = $remote->selectRoom();
			
			foreach($remoteRoom as $value){
				array_push(static::$cachedRoom,$value);	
			}		
			echo "cached finfish!".PHP_EOL;
			return static::$cachedRoom;
		}else{
			echo "I already have cached".PHP_EOL;
			return static::$cachedRoom;
		}
	}	
}
