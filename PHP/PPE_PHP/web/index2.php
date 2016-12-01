<?php

require_once __DIR__.'/../vendor/autoload.php';

$app = new Silex\Application();

require __DIR__.'/../app/config/dev2.php';
require __DIR__.'/../app/app2.php';
require __DIR__.'/../app/routes2.php';

$app->run();
