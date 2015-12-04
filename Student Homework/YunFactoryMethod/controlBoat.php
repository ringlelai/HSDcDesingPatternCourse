<?php

include_once('./iControlVehicle.php');
class controlBoat implements iControlVehicle{
	public function launchVehicle(){
		echo "Boat launchs.".PHP_EOL;	
	}
	public function left(){
		echo "Boat turn left.".PHP_EOL;
	}
	public function right(){
		echo "Boat turn right.".PHP_EOL;
	}
	public function forward(){
		echo "Boat forward.".PHP_EOL;
	}
	public function back(){
		echo "Boat back.".PHP_EOL;
	}
	public function stopVehicle(){
		echo "Boat stop.".PHP_EOL;
	}
}
