FROM alpine

RUN sleep 10 
#RUN apt-get update && apt-get install blabla

RUN sleep 10

RUN mkdir /renan/

ENTRYPOINT [ "/teste.sh" ]

ADD ./teste.sh /teste.sh

RUN chmod +x /teste.sh
