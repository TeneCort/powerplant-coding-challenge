# powerplant-coding-challenge

This repo is an implementation of the following [challenge](https://github.com/gem-spaas/powerplant-coding-challenge)

The implementation assumes the following due to time restriction:

- Generated MWh are not integer value

- Total wind power generation will not exceed the load

---

# Instructions to use the app

Clone the repo localy and open the folder containing the app

## Using Docker
 	
using a terminal 

run `docker build . -t powerplant-coding-challenge`

run `docker run --name powerplant-coding-challenge -p 8888:80 -d powerplant-coding-challenge`

Do a POST call to http://localhost:8888/productionplan with the HEADER set to 'Content-Type: application/json' using the JSON data provided by the challenge found [here](https://github.com/gem-spaas/powerplant-coding-challenge/blob/master/example_payloads/payload1.json) as the body

## Using Visual Studio 2022

using a terminal 

run `dotnet restore`

Build and run the solution

Use Swagger UI at https://localhost:8888/swagger/index.html

Or 

Do a POST call to https://localhost:8888/productionplan with the HEADER set to 'Content-Type: application/json' using the JSON data provided by the challenge found [here](https://github.com/gem-spaas/powerplant-coding-challenge/blob/master/example_payloads/payload1.json) as the body

---

# Improvements

Body content validation

Add depth when checking if turning a power plant on will exceed the load (Current depth is n-1)

Explore usage of genetic or random forest tree algorithms for a more robust implementation