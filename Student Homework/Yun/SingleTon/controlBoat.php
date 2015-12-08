<?php

include_once('./iVehicle.php');
class controlBoat implements iVehicle{
	public function launch(){
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
	public function stop(){
		echo "Boat stop.".PHP_EOL;
	}
}
