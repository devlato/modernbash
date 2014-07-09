#!/bin/bash


source std


use console
use fs
use network


fs.createFile "file.txt"
fs.createDirectory "dir/recursiveDir"
fs.setUnixPermission "file.txt" 777
fs.setUnixPermission "dir" 777 true
fs.unlink "file.txt" "dir"
network.ping "yandex.ru" 4
