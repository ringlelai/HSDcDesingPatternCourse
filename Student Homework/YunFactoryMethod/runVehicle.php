<?php

include_once('./createVehicle.php');

$car = createVehicle::createVehicle('controlCar');
$boat = createVehicle::createVehicle('controlBoat');

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