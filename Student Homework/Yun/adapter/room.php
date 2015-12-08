<?php

class room{
	public function __construct(){}
	public function roomList(iAdapterRoom $roomObject){
		$room = $roomObject->selectroom();
		foreach($room as $value){
			echo PHP_EOL;
			echo "roomId:".$value['roomId'].PHP_EOL;
			echo "roomName:".$value['roomName'].PHP_EOL;
			echo "roomNumbers:".$value['roomNumbers'].PHP_EOL;
			echo PHP_EOL;
		}
	}
}
