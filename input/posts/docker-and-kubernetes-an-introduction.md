Title: Docker and Kubernetes - An Introduction
Published: 2021-09-01
Image: /assets/container-ship.jpeg
Tags: [Docker, Kubernetes, DevOps, Distributed applications]
---

There are two pieces of software that everybody is talking about right now: Docker and Kubernetes.

## Docker

Docker is a virtualization software that lets you build composable software parts, called "images", that then run in isolated compartments: "containers".

Imagine wanting a Web Server. Instead of manually installing and configuring Nginx ("Engine-X") in a Virtual Machine, you just tell Docker to download and run a pre-built image, and it is up and running in seconds. 

If you restart the container, it will start up clean again. And when you are done, you just delete the container, and there is no trace of ever having it on your system.

### How it works

Docker is virtualization at Operating System (OS) level. It runs on top of an existing OS kernel - usually the Linux kernel. The kernel is the lowest level of an operating system which handles the computer's resources. So instead of being virtualized as a full virtual machine, by a software called a *hypervisor*, each Docker container shares the kernel resources of the host operating system. Each container has its own separate filesystem, and houses their own OS distribution. This allows Docker containers to be lightweight, as opposed to traditional virtual machines.

Linux is not itself an operating system, but a kernel that is being used by multiple Linux distributions - such as Ubuntu and CentOS, which are the actual operating systems, each containing their own set of programs and desktop environments.

### Composability

Docker images are layered so you can build your own images with your software on top of existing base images. Use Nginx as a base, and then add the files for your site on top. You've got a new Docker image!

Now you can distribute the image, and others can easily run it without having to install any dependencies except Docker.

The Nginx image is based on an image of the lightweight Alpine Linux distribution. So that is how Docker put software in composable layers.

### How it relates to Microservices

You have probably heard of Docker in the context of "microservices". A "microservice" is an independently deployable software service - as opposed to a big service monolith that is published all at once. A microservice might run in a container in Docker, and interact with other containers. The communication is done through HTTP, RPC - or via Asynchronous Messaging through a message queue like RabbitMQ, which also can run in a separate container.

An application that is distributed across multiple separate applications or services (or replicas), such as a microservice, is called a "Distributed application" or a "Distributed system".

## Kubernetes

If you want to run containers in a Production environment, then you should consider using Kubernetes:

Kubernetes is a software that orchestrates containers and how they communicate with each other. It enables replication, load-balancing, and it can even restart services in case a container is down. It also provides capabilities for monitoring and controlling how you are exposing services to the outside world.

## Conclusion

This was a short introduction to Docker and Kubernetes. I hope that this was useful in understanding these two products.