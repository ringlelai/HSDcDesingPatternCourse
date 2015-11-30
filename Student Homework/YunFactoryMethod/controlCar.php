<?php
include_once('./iControlVehicle.php');
class controlCar implements iControlVehicle{
	public function launchVehicle(){
		echo "Car launchs.".PHP_EOL;	
	}
	public function left(){
		echo "Car turn left.".PHP_EOL;
	}
	public function right(){
		echo "Car turn right.".PHP_EOL;
	}
	public function forward(){
		echo "Car forward.".PHP_EOL;
	}
	public function back(){
		echo "Car back.".PHP_EOL;
	}
	public function stopVehicle(){
		echo "Car stop.".PHP_EOL;
	}
}