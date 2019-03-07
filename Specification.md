# **Software Requirements Specification**
24th February 2018 - [IDK]
<br/>
<br/>
A software Specification document for a platform game using Unity. <br/>

# Introduction
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
The objective of this project is to make a simple game that is targetted for minors around the age of 3-5. The game should be appropriate for the targetted age range (which means no blood, violence, or any extreme imagery), simple to understand, simple controls, and fun. The client has also made a special request to develop the game using Unity. 
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
- The player should be able to attempt to complete the game by doing the game's objectives with obstacles. 
- The player should be able to finish the game to know how well they did in the game. 

# System Overview
This section will explain how the whole game works. It will be explained how each part of the game will interact with each other, along with highlights of basic functionality. The explainations will be supported with UML Diagrams. 

# Functional Requirements of the System
This section includes requirements that specify the system's fundemental behaviour and actions. 

# Functional Requirements
Title[ID] | Description | Verification Method 
------------ | ------------- | ------------ 
Launch the game app [FR1] | The user should be able to start the game app successfully within a minute. | Demonstration 
Start the game [FR2] | The player should be able to start playing the game. | Demonstration
Player Control [FR3] | The player should be able to control the game player sprite. | Demonstration
Jump [FR4] | The player should be able to jump on the platform. | Demonstration
Double Jump [FR5] | The player should be able to perform a double jump midair once until they land on a platform. | Demonstration
Life System [FR6] | The game have a life system where the game will ends if the player's lifes are reduced to 0 | Demonstration
Score System and Scoreboard [FR7] | The game have a score system that keep track's the player's performance during the game | Demonstration
Collect Objects [FR8] | There should be an object ingame that spawns randomly that increases the player's score if the player collides with it | Demonstration
Enemies and Hazards [FR9] | There should be enemies and environmental hazards ingame that reduces the player's life count upon collision | Demonstration
Power Ups [FR10] | There should be power ups that modify how the character behaves positively upon inputs | Demonstration
Negative Power Ups [FR11] | There should be negative power ups that modify how the character behaves negatively upon inputs | Demonstration
Level(s) [FR12] | The game should at least contain a single level where the player plays | Demonstration
Music [FR13] | Various music and sound effects should play when the player plays the game (background, sound effects, upon win, upon lose, get high score, etc) | Demonstration
Tutorial Page [FR14] | There should be a page/mechanic ingame to teach the player the objective of the game, obstacles, and how to control the player sprite | Demonstration
Main Menu [FR15] | There should be a menu when the player first open the game for players to start a game, see the game's controls, credits, and quit | Demonstration


# Non-functional Requirements of the System
Title[ID] | Description | Verification Method
------------ | ------------- | ------------  
Response Time [NR1] | Majority of tasks should be able to be completed within milliseconds | Demonstration 
Game Crash [NR2] | When a game crash happens, the game shouldn't damage the user's PC | Demonstration 

## Other Requirements 
#### User Interfaces
A User friendly application will be presented on the user's PC. With how young the intended audience in mind, the UI should be very simple to understand and responsive.
#### Hardware Requirements
There are no direct hardware interface. 
#### Software Requirements
- Operating System: Windows - For best support and user friendliness. 
- Client's Request: The client has requested us to use Unity engine to develop the game and and run the game. 
#### Safety Requirements
Due to the target age range, the game must be family friendly. (No inappropriate graphics such as violence, blood, and drugs)
