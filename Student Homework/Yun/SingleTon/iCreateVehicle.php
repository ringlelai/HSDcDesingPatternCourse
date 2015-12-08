<?php

require_once './controlCar.php';
require_once './controlBoat.php';

class iCreateVehicle{
	protected static $vehicle;
	
	public static function newVehicle($importVehicle){
		if(empty(static::$vehicle)){
			static::$vehicle = new $importVehicle;
			echo "Vehicle is stead by!".PHP_EOL;		
		}else{
			echo "You can't driver two vehicle at the same time!".PHP_EOL;
		}
	}
	
	public static function destoryVehicle(){
		static::$vehicle = null;
	}
}