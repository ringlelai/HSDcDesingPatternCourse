<?php

abstract class iCreateVehicle{
	protected $vehicle;
	abstract public function newVehicle(iVehicle $importVehicle);
}