<?php

require_once './iCreateVehicle.php';
require_once './controlCar.php';
require_once './controlBoat.php';

class createVehicle extends iCreateVehicle{
	public function newVehicle(iVehicle $importVehicle){
		$this->vehicle = $importVehicle;
	}
	
	public function autoTest(){
		$this->vehicle->launch();
		$this->vehicle->left();
		$this->vehicle->right();
		$this->vehicle->forward();
		$this->vehicle->back();
		$this->vehicle->stop();
	}
}
