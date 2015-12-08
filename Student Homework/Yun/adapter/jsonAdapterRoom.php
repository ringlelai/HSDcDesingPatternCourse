<?php

require_once './iAdapterRoom.php';

class jsonAdapterRoom implements iAdapterRoom{
	public function selectRoom(){
		$jsonFile = fopen('./room.json',"r");
		$jsonRoom = fread($jsonFile,filesize('./room.json'));
		$room = json_decode($jsonRoom,true);
		return $room;
	}
}