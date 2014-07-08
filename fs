#!/bin/bash


source std
use console


#---
## Create and clear file
## @param  [List of] Files to create and clear
#---
fs.createFile() {
	console.log "fs::createFile($@)"
	local files=$@
	for file in $files; do
		echo > "$file";
	done;
}


#---
## Create directory
## @param  [List of] Paths to create
#---
fs.createDirectory() {
	console.log "fs::createDirectory($@)"
	local paths=$@
	for path in $paths; do
		mkdir -p "$path";
	done;
}


#---
## Set Permissions
## @param  File/Directory to set permission
## @param  Unix permission mode
## @param  Is recursive?
#---
fs.setUnixPermission() {
	console.log "fs::setUnixPermission($@)"
	local file=$1
	local mode=$2
	local isRecursive=""
	if [[ ! -z $3 ]]; then
		isRecursive="-R"
	fi;
	local command="chmod $isRecursive $mode $file"
	eval $command
}
