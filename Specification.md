# **Software Requirements Specification**
24th February 2018 - [IDK]
<br/>
<br/>
A software Specification document for a platform game using Unity. <br/>

# Intruduction
This section will describe the purpose of the SRS document along with the list of definitions and acronyms. 

### Document Purpose
The purpose of this document is to list detailed descriptions of behaviours and requirements along with for a 2D platformer game. Goals of the software will be stated. This document will describe and illustrate the system's functionality, interactions with users, and some example scenarios. This document is primarily intended to be written for the client. 

### Definitions and Acronyms
This document follows the following conventions: <br/>

Term | Definition
------------ | -------------
PC | Personal Computer
SRS | Software Requirements Specification
UI | User Interface


# Informal Requirements Report

### System Objective and Background
The objective of this project is to make a simple platformer game that is targetted for minors around the age of 3-5. The game should be appropriate for the targetted age range (which means no blood, violence, or any extreme imagery), simple to understand, simple controls, and fun. The client has also made a special request to develop the game using Unity. 
<br/>

### Target User and Stake Holders
Target: Users who wants to play an engaging platformer game to have fun. 
<br/>
<br/>
Users/Players are assumed:
- To be above 3 years old.
- Have access to a PC.
- Extremely basic experience of using a PC.

Stakeholder:
- Client

### User Stories
The following are the user stories as a general guideline of our design and implementation of the game:
<br/>
- The player should be able to start the game application to be able to begin their game. 
- The player should be able to move their character with a keyboard to control their character in-game. 
- The player should be able to finish the game to know how well they did in the game. 

# System Overview
This section will explain how the whole game works. It will be explained how each part of the game will interact with each other, along with highlights of basic functionality. The explainations will be supported with UML Diagrams. 

# Functional Requirements of the System
This section includes requirements that specify the system's fundemental behaviour and actions. 

#### Functional Requirements
Title[ID] | Description | Verification Method | Rationale
------------ | ------------- | ------------ | ------------ 
User registeration [FR1] | The user should be able to register and make an account from the EC. | Demonstration | In order for users to be able to start using the ES. 

# Non-functional Requirements of the System
Title[ID] | Description | Verification Method | Rationale
------------ | ------------- | ------------ | ------------ 
EC to Server Encryption [NR6] | Communication between the EC and the server must be encrypted with HTTPS | Packet Sniffing and Analysis | Security measure to prevent hackers to sniff user login details.
