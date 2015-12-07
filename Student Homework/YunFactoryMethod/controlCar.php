<?php
include_once('./iVehicle.php');
class controlCar implements iVehicle{
	public function launch(){
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
	public function stop(){
		echo "Car stop.".PHP_EOL;
	}
}