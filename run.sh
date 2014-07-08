#!/bin/bash


source std


use console
use fs


fs.createFile "file.txt"
fs.createDirectory "dir/recursiveDir"
fs.setUnixPermission "file.txt" 777
fs.setUnixPermission "dir" 777 true
