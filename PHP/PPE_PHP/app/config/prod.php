<?php

// Doctrine (db)
$app['db.options'] = array(
    'driver'   => 'pdo_mysql',
    'charset'  => 'utf8',
    'host'     => 'localhost',
    'port'     => '3306',
    'dbname'   => 'microcms',
    'user'     => 'microcms_user',
    'password' => 'secret',
    // Pour notre BDD (commune à celle C#)
    //'dbname'   => 'backoffice_gsb',
    //'user'     => 'root',
    //'password' => 'root',
);
