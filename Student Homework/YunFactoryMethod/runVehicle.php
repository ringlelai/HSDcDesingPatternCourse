<?php

include_once('./controlCar.php');
include_once('./controlBoat.php');

$car = new controlCar;
$boat = new controlBoat;

//start car
$car->launchVehicle();
$car->left();
$car->right();
$car->forward();
$car->back();
$car->stopVehicle();

//start boat
$boat->launchVehicle();
$boat->left();
$boat->right();
$boat->forward();
$boat->back();
$boat->stopVehicle();