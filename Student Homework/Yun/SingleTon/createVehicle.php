<?php

require_once './iCreateVehicle.php';

class createVehicle extends iCreateVehicle{
	
	private function __construct()
    {
    }
	
	
	public static function autoTest(){
		static::$vehicle->launch();
		static::$vehicle->left();
		static::$vehicle->right();
		static::$vehicle->forward();
		static::$vehicle->back();
		static::$vehicle->stop();
	}
	
}
