<?php

include_once('./createVehicle.php');

createVehicle::newVehicle('controlBoat');
createVehicle::newVehicle('controlBoat');
createVehicle::autoTest();
createVehicle::destoryVehicle();
createVehicle::newVehicle('controlCar');
createVehicle::autoTest();
