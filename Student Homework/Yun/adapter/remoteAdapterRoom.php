<?php

require_once './iAdapterRoom.php';

class remoteAdapterRoom implements iAdapterRoom{
	public function selectRoom(){
		return array(0=>array('roomId'=>1,'roomNumbers'=>3,'roomName'=>'designPattern'));
	}
}