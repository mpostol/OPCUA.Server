# OPC UA Server

## Preface

 `CommServer UA` is redundant, multi-protocol, multi-channel OPC Unified Architecture Server for highly distributed systems. It is a package of software to manage data transfer. Built-in technologies and algorithms provide a smart data transmission that automatically adapts its parameters to the process needs and underlying communication network capabilities. To learn more about `CommServer` software family visit the [software home page][comsvr] and [CommServer Online Help Documentation][help].

This project is aimed at `CommServer UA` software development and maintenance published as the Open-Source Software (OSS). OSS is a type of computer software in which source code is released under a license in which the copyright holder grants users the rights to study, change, and distribute the software to anyone and for any purpose. The `CommServer UA` software was written by CAS Lodz Poland. I am the founder and Executive Director of CAS. Now CAS is just an individual business activity conducted by me, so I decided to move this software to Open Source.

## OPC UA communication stack dependency

### Design decision

The in-band communication is implemented based on the OPC Unified Architecture specification. By design, the software depends on an external OPC UA SDK. According to the feature request

- [OPCFoundation/UA-.NETStandard shall be used as the OPC UA stack](https://github.com/mpostol/OPCUA.Server/issues/3)

I have decided to migrate from the OPC UA SDK released internally by CAS to [OPCFoundation/UA-.NETStandard][UASDK]. The following subsections provide a background for this decision.

### .NET Standard

To promote portability this OPC UA server implementation is targeting .NET Standard specification.

### Open Source (TBD)

- benefits
- risks

Consider the descriptions:

- [What Is Open-Source Software? (+The Benefits and Risks)](https://learn.g2.com/open-source-software)
- [10 advantages of open source for the enterprise](https://opensource.com/article/17/8/enterprise-open-source-advantages)

### Documentation (TBD)

- code documentation
- OPC UA SDK code documentation
- product documentation

### How to be rewarded

As a result of direct contribution to the OPC UA SDK development or using the deliverables as the end user you

- can directly influence further development of the OPC UA SDK prioritizing the tasks in the backlog
- will access OPC UA SDK documentation and deliverables
- will have opportunities to join collaborations for new technology initiatives

### Standard development and maintenance

The standardization process may be "paper-driven" or "community-driven". In both cases, standardization is indispensable but not sufficient. Let me recall that the foundation for the human-centric global village is just the Internet Protocol (IP) defined in 1981 and derived from the academic abstract knowledge and practitioners' concrete experience. It is worth stressing that it was published as an open-access document (RFC 791) that has not been deprecated yet. As a result, Information and Communication Technology (ICT) has provided society with a vast variety of distributed applications. By design, the deployment of this kind of application has to focus primarily on communication.

My concern is if current standardization proposals covered by the OPC Unified Architecture specs suits are adequate to address the challenges of further development of the Internet of Things (IoT) and Industry 4.0 concepts targeting multi-vendor plug-and-produce interoperability scenario. These doubts may be expressed as a crucial question:

- **Do we need Rel 2.0 of the OPC UA?**

Nothing is done forever, hence this question will arise sooner or later. Based on my research on [Object-Oriented Interned](https://commsvr.gitbook.io/ooi/readme) described in:

[Chapter Object-Oriented Internet Reactive Interoperability](https://rdcu.be/b44WS) available at [https://rdcu.be/b44WS](https://rdcu.be/b44WS) (open access)

my opinion is that the question is not if but rather how. The answer must be a tradeoff between backward compatibility and further innovation deployment.

"Community-driven" standardization improves flexibility and relaxes natural software vendor and standardization organization reluctance to be innovative.

## Contributing

Please read CONTRIBUTING.md for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [Semantic Versioning 2.0.0](http://semver.org/) for versioning. For the versions available, see the \[releases\] page of the project.

## Authors

- [Mariusz Postol](https://github.com/mpostol) - main contributor of this project.

See also the list of contributors who participated in this project.

## License

This project is licensed under the MIT License - see the \[LICENSE.md\] file for details.

>TODO add information about dependencies.

## Walk through (TBD)

## Main Technology Features

### Description

`CommServer UA` is a package of communication software to manage data transfer. It’s a fully configurable OPC UA server that provides a multi-protocol, multi-medium and multi-channel redundant access to physical process control device data (out-of-band communication). To ensure short response time and effective utilization of the physical device communication channels throughput, a unique scan on-demand algorithm was implemented.

`CommServer UA` software provides:

- Integration of production supervision systems (MES, SCADA) with management systems of operations and supplies in an enterprise (ERP, SAP, CRM).
- [`ProcessObserver`][PO] - a uniform communication engine.
- Optimization of communication infrastructure utilization of visualization and supervision systems,
- Considerably easier (cheaper) extension and connection of the next objects.
- Increase of functionalities and efficiencies of the existing systems.
- Creation of OPC UA servers for non-standard (own) protocols.

As a result, it is possible to create one, open and universal, intelligently administered platform of data exchange in an enterprise, access to all systems, instead of the creation of separate infrastructure for each individual system.

`CommServer UA` offers the possibility of using many communication protocols simultaneously, parallel handling of independent communication channels and redundant links with remote physical devices. Any user can define logical sets of devices (segments) with common addresses or scanning rules (e.g. connected by one ISDN modem or satellite transceiver). New protocols can be added easily by plug-ins. It provides the possibility of using various communication media simultaneously, including copper and fibreoptic wires, digital radio, ISDN, GSM and satellite transponders. The physical data communication network is monitored and the acquired diagnostic data are provided as OPC UA nodes in the address space.

`CommServer UA` offers a unique algorithm of scheduling the process of the physical device data cache update, basing on original solutions in the field of multithreaded technology. The unique scanning on-demand algorithm manages dynamic priority allocation by the scheduling procedure of the cache update using common scanning rules defined for physical process variables grouped into sets. The priority of the group and, as a consequence, the device polling period is a function of the state of selected alarm variables.

One of the biggest improvements in OPC UA is a powerful Address Space and Information Model. OPC UA allows for the presentation of a real-time process and underlying infrastructure as a consistent information model built up with nodes. The process model is represented by nodes, attributes, and their mutual relationships. Therefore, this powerful concept allows us to present in UA not only raw process data but also complete information about the process state and process environment. The flexibility of UA ensures that there is no existing or future system that is too complicated to be exposed via UA. Of course, such flexibility leads to complications during configuration, that’s why OPC UA Address Space Model Designer is used to prepare the configuration for the CommServer UA. The whole configuration can be prepared using a user-friendly Windows-based GUI. All nodes are presented on a tree and can be edited in the property window.

### Fetuses Summary

- Multi-protocols (new protocols can be added by plug-ins)
- Protocol-independent - ones the user has defined the process variables and scanning rules, the protocol can be changed easily without any change of the previous configuration
- Multi-link and redundancy capabilities (physical devices can be accessed using different protocols, channels, segments and interfaces coupled together in virtual communication pipes)
- Advanced polling algorithm - scanning on demand – minimizes utilization of the physical data communication channels
- Diagnostic information is provided by OPC UA variables and a management console
- Implementation of a watchdog mechanism that prevents deadlock in case of faulty configuration or malfunction
- Significant information is logged in Windows Application Log
- It takes the advantages of the most recent technology -.NET Framework

A major advantage of the CommServer UA is the ability to connect it to an unlimited number of data sources using external components - plug-ins, which extend the functionality of the server. This makes it possible to include new sources from which data can be obtained and exposed in the OPC UA Address Space. The following are examples of data sources that can be used:

- multi-protocol universal communication engine implementing [Process Observer][PO] architecture - a standardized, homogenous real-time model of the process layer, from which data from plant floor devices are - shared by the process control and management systems,
- any industrial devices such as PLC controllers,
- databases,
- OPC servers - that wrap the classic DA server and provide data in the OPC UA Address Space,
- simulator - easy test data generator, and software implementation and training,
- and many more ...

This software package contains:

- OPC UA Wrapper
- UA Model Designer
- OPC UA Servers:
  - OPC UA Server for Excel
  - OPC UA Server for M-BUS
  - OPC UA Server for Modbus (IP)
  - OPC UA Server for Modbus (RS)
  - OPC UA Server for SAIA (IP)
  - OPC UA Server for SAIA (RS)
- OPC Viewer
- Diagnostic Tools

## See also

- [CommServer Online Help Documentation][help]
- [CAS CommServer UA](https://www.commsvr.com/index.php/home/opc-ua-server)
- [CommServer software Migration and Maintenance](https://github.com/commsvr-com/migration2os)
- [OPC UA Makes Machine-Centric Global Village Possible – Call for Sponsors][Wordpress.Sponsors]
- [Object Oriented Internet - C# deliverables supporting a new Machine To Machine (M2M) communication architecture; GitHub repository][OOI]
- [OPC UA Address Space Model Designer; GitHub repository](ASMD)
- [CommServer - Home Page][comsvr]
- [CAS Lodz Poland Home Page][CAS]
- [My Blog: About enablers of future solutions](http://wwww.mpostol.wordpress.com/)
- [About me on LinkedIn](https://pl.linkedin.com/in/mpostol)
- [OPC Foundation](https://opcfoundation.org/)
- [Official OPC UA .Net Standard Stack from the OPC Foundation][UASDK]
- Postół M. (2020) Object-Oriented Internet Reactive Interoperability. In: Krzhizhanovskaya V. et al. (eds) Computational Science – ICCS 2020. ICCS 2020. Lecture Notes in Computer Science, vol 12141. Springer, Cham; [DOI: https://doi.org/10.1007/978-3-030-50426-7_31](https://doi.org/10.1007/978-3-030-50426-7_31)
  - Postół M. (2020) [Object-Oriented Internet Reactive Interoperability](https://www.researchgate.net/publication/341882427_Object-Oriented_Internet_Reactive_Interoperability), presentation, DOI: 10.13140/RG.2.2.33984.56323
- Mariusz Postol, [Machine to Machine Semantic-Data Based Communication: Comprehensive Survey](https://www.researchgate.net/publication/341165347_Machine_to_Machine_Semantic-Data_Based_Communication_Comprehensive_Survey) chapter in book [Computer Game Innovations 2018](https://www.researchgate.net/publication/335524620_Computer_Game_Innovations_2018), Publisher: Lodz University of Technology Press; ISBN: 978-83-7283-999-2
- Mariusz Postol, [Object Oriented Internet](https://ieeexplore.ieee.org/abstract/document/7321562), [3rd International Conference on Innovative Network Systems and Applications](https://fedcsis.org/2015/inetsapp), 2015, [IEEE Xplore Digital Library](https://ieeexplore.ieee.org/abstract/document/7321562) [![DOI](https://img.shields.io/badge/DOI-10.15439%2F2015F160-blue)](https://fedcsis.org/proceedings/2015/pliks/160.pdf)
- [Real-Time Communication for Large Scale Distributed Control Systems][POCommSvr]

[Wordpress.Sponsors]: https://mpostol.wordpress.com/2020/01/03/opc-ua-makes-machine-centric-global-village-possible-call-for-sponsors/
[CodeProtect]: https://github.com/mpostol/CodeProtect
[CAS]:https://www.cas.eu/
[comsvr]:https://www.commsvr.com/
[asmdn]:https://github.com/mpostol/ASMD/tree/master/_nugets
[OOI]:https://github.com/mpostol/OPC-UA-OOI
[ASMD]:https://github.com/mpostol/ASMD
[PO]:https://github.com/mpostol/ProcessObserver#process-observer
[POCommSvr]:https://www.researchgate.net/publication/228848488_Real-Time_Communication_for_Large_Scale_Distributed_Control_Systems
[help]:https://commsvr-com.github.io/Documentation/CommServer/html/2dea0752-d490-47e6-8444-ac73e07601fc.htm
[UASDK]:https://github.com/OPCFoundation/UA-.NETStandard
