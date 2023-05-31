FROM centos:centos7

WORKDIR /dotnet

RUN yum -y update && \
    yum install -y wget libicu && \
    wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh && \
    chmod +x ./dotnet-install.sh && \
    ls && \
    bash ./dotnet-install.sh --channel 7.0 

ENV PATH="$PATH:/root/.dotnet:/root/.dotnet/tools"
