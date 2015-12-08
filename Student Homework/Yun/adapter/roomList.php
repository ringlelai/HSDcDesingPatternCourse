<?php

require_once './room.php';
require_once './jsonAdapterRoom.php';
require_once './remoteAdapterRoom.php';

$list = new room();
$list->roomList(new jsonAdapterRoom());
$list->roomList(new remoteAdapterRoom());