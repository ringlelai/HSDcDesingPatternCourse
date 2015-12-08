<?php

include_once('./createVehicle.php');

$vehicle = new createVehicle();
$vehicle->newVehicle(new controlBoat());
$vehicle->autoTest();
$vehicle->newVehicle(new controlCar());
$vehicle->autoTest();