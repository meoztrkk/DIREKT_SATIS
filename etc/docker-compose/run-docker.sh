#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 838e32a6-5334-4ad0-a831-a1d208fb037b -t
    fi
    cd ../
fi

docker-compose up -d
