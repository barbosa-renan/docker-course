#!/bin/sh

clear &&
docker build . -t app_demo1 &&
docker run app_demo1