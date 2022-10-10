# docker training app

## example to use 

This example connect to containers in *bridge* network.
One container contains the mongo db storing some customer data, the other contains the webapp.

## how to use

This app adds *customers* to the db when the *privacy* is viewed.
The customers can be seen on the *home* page 

## starting app

Create a `bridge` network.  
`docker network create -d bridge isolated_network`

Run a mongo db conatiner in the isolated network.  
`docker run -d --net isolated_network  --name mongodb mongo`

Build a docker container with tag name:  
`docker build -t psilearn/aspdotnetcore .`

Run created container in isolated network.  
`docker run -p 80:80 -p 443:443 -p 5000:5000 -p 5001:5001 --net isolated_network psilearn/aspdotnetcore`
