<?php

class createVehicle{
	function __construct(){}
	public static function createVehicle($vehicle){
		$filePath = './'.$vehicle.'.php';
		if(file_exists($filePath)){
			include_once($filePath);
			return new $vehicle;
		}
	}
}
