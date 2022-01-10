#!/bin/sh

curl --url https://www.google.com -o /home/index.html

echo "Eita acessei o google.com"

sleep 4

cat /home/index.html

sleep 4

echo "Finalizado com sucesso!!"
