MultiAgent-HyperSharpNEAT Simulator Documentation

MultiAgent-HyperSharpNEAT Simulator Now Including the Evolvable Substrate v1.0 C#,
By David D'Ambrosio, Joel Lehman, and Sebastian Risi
http://eplex.cs.ucf.edu
ddambro@eecs.ucf.edu, jlehman@eecs.ucf.edu, sebastian.risi@gmail.com

Faculty Supervisor: Kenneth Stanley
kstanley@eecs.ucf.edu

Documentation for this package is included in this README file. 

-------------
1. LICENSE
-------------

Some of this code is from Colin Green's SharpNEAT 1.0 (http://sharpneat.sourceforge.net/).  All original SharpNEAT code is covered by the original SharpNEAT license as described by Colin Green:

"The SharpNeat project consists of the core code packaged as SharpNeatLib and the main application simply called SharpNeat. SharpNeatLib is released under the Gnu Lesser General Public License (LGPL) which means you can link to it from your own programs, proprietory or otherwise.

The SharpNeat application is released under the Gnu General Public License (GPL).

The additional applications, PreyCaptureSimulator and PoleBalancingSimulator have no license and are public domain. Modify them at your will."

This package contains HyperSharpNEAT which modifies original SharpNEAT 1.0 to implement HyperNEAT and add additional functionality such as Novelty Search and Evolvable-Substrate HyperNEAT (ES-HyperNEAT).  Additionally it includes a multiagent simulator.

The HyperNEAT additions and simulator are covered by the following license:

This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2 as published by the Free Software Foundation (LGPL may be granted upon request). This program is distributed in the hope that it will be useful, but without any warranty; without even the implied warranty of merchantability or fitness for a particular purpose. See the GNU General Public License for more details.

---------------------
2. USAGE and SUPPORT
---------------------

We hope that this software will be a useful starting point for your own explorations in multiagent simulation and neuroevolution. The software is provided as is, however, we will do our best to maintain it and accommodate suggestions. If you want to be notified of future releases of the software or have questions, comments, bug reports or suggestions, send email to one of the authors.

Alternatively, you may post your questions on the NEAT Users Group at : http://tech.groups.yahoo.com/group/neat/.

The following explains how to use the software packages.  For information on compiling, please see the section on compiling below.

INTRO
-----
This package makes use of HyperNEAT, which is an extension of NEAT (NeuroEvolution of Augmenting Topologies) that evolves CPPNs (Compositional Pattern Producing Networks) that encode large-scale neural network connectivity patterns.  A complete explanation of HyperNEAT is available here:

@Article{stanley:alife09,
  author       = "Kenneth O. Stanley and David B. D'Ambrosio and Jason Gauci",
  title        = "A Hypercube-Based Indirect Encoding for Evolving Large-Scale Neural Networks",
  journal      = "Artificial Life",
  volume       = 15,
  number       = 2,
  pages        = "185--212",
  year         = 2009,
  url          = "http://eplex.cs.ucf.edu/papers/stanley_alife09.pdf",
  publisher    = "MIT Press",
  address      = "Cambridge, MA"
}

The version of HyperNEAT distributed in this package executed the experiments in the following paper, with a few alterations:

@InProceedings{dambrosio:aamsa2010,
  author       = "David B. D'Ambrosio and Joel Lehman and Sebastian Risi and Kenneth O. Stanley",
  title        = "Evolving Policy Geometry for Scalable Multiagent Learning",
  booktitle    = "Proceedings of the Ninth International Conference on Autonomous Agents and Multiagent Systems (AAMAS-2010)",
  year         = 2010,
  publisher    = "IFAAMAS: International Foundation for Autonomous Agents and Multiagent Systems",
  site         = "Toronto, Canda",
  url          = "http://eplex.cs.ucf.edu/papers/dambrosio_aamas10.pdf"
}

The version of HyperNEAT distributed in this package also contains an implementation of novelty search, which is described here:

@Article{lehman:ecj11,
 author = �Joel Lehman and Kenneth O. Stanley�,
 title=�Abandoning Objectives: Evolution Through the Search for Novelty Alone�,
 journal=�Evolutionary Computation�,
 publisher= �MIT Press�,
 address = �Cambridge, MA�,
 year= 2011,
 volume = {19},
 number= {2},
 pages={189--223}, 
 url="http://eplex.cs.ucf.edu/papers/lehman_ecj11.pdf"
}
,
an implementation of Evolvable-Substrate HyperNEAT (ES-HyperNEAT), which is described here:

@InProceedings{risi:gecco2011,
  author       = "Sebastian Risi and Kenneth O. Stanley",
  title        = "Enhancing ES-HyperNEAT to Evolve More Complex Regular Neural Networks",
  booktitle    = "Proceedings of the Genetic and Evolutionary Computation Conference (GECCO-2010)",
  year         = 2011,
  publisher    = "ACM",
  url          = "http://eplex.cs.ucf.edu/papers/risi_gecco11.pdf"
}
,
and an implementation of situational policy geometry for multiagent HyperNEAT, which is described here:

@InProceedings{dambrosio:iros2011,
  author       = "David B. D�Ambrosio and Joel Lehman and Sebastian Risi and Kenneth O. Stanley",
  title        = "Task Switching in Multiagent Learning through Indirect Encoding",
  booktitle    = "Proceedings of the International Conference on Intelligent Robots and Systems  (IROS2011)",
  year         = 2011,
  publisher    = "IEEE",
  url          = "http://eplex.cs.ucf.edu/papers/dambrosio_iros11.pdf"
}

For more information, please visit the EPlex website at:
http://eplex.cs.ucf.edu/

or see more of our publications on HyperNEAT and CPPNs at:
http://eplex.cs.ucf.edu/publications
or 
http://eplex.cs.ucf.edu/hyperNEATpage/HyperNEAT.html

EXECUTABLE
----------
The executable "AgentSimulator.exe" is located in the "data" directory of the same project.  It runs the multiagent room-clearing experiment described below with the parameters in the params.txt file.  Descriptions of how to change the experiment in the GUI and commandline mode are included below.

The project files that are included should also allow for easy compilation either in Microsoft's Visual Studio or in monodevelop on Linux.

--------------
3. EXPERIMENTS
--------------

When run, the experiments will output the generation number, the fitness, and the amount of time per generation, for each generation.  The experiment will also write out an XML file containing the highest fitness genome whenever a new maximum fitness is reached.

ROOM CLEARING EXPERIMENT
-------------------------
The room-clearing experiment with multiagent hyperneat (�roomclear_exp_hetero.xml) is presented in the 2010 AAMAS paper (see above) . The goal of the experiment is for a group of agents to view as much of a room as possible. For comparison purposes, the same experiment with homogenous teams (�roomclear_exp_homo.xml�) is also included.
----------------------------
EVOLVABLE-SUBSTRATE NAVIGATION EXPERIMENT 

The maze navigation experiment (�hardmaze_exp.xml�) is presented in the 2011 GECCO paper on ES-HyperNEAT (see above). The goal of the agent is to navigate from a starting to an end location. The main ES-HyperNEAT code can be found in the SharpNeatLib\CPPNs\EvolvableSubstrate.cs class. The main method in that class is �generateConnections�, which generates a list of ANN connections and hidden nodes based on the information in the underlying CPPN. This function is called from the SubstrateDescription.cs class. The parameters for ES-HyperNEAT can be changed in the params.txt file (see below). Note that this is a single-agent experiment that does not support increasing the number of agents. For questions on ES-HyperNEAT email sebastian.risi@gmail.com
--------------------------
PATROL AND RETURN
The patrol and return experiment with situational policy geometry (�patrol_switch.xml�) is presented in the 2011 IROS paper above.  The goal is for the team of agents to spread out among an environment, and then return to their starting place. For comparison purposes, the same experiment, but without situational policy geometry (�patrol_signal.xml�) is also included.

PARAMETER FILE
--------------------------

The main parameters of HyperNEAT can be changed in the included params.txt using this guide:

Threshold .2
WeightRange 3
NumberofThreads 1
SubstrateActivationFunction SteepenedSigmoid
StartActivationFunctions
BipolarSigmoid .25
Sine .25
Gaussian .25
Linear .25
EndActivationFunctions

//Evolvable-Substrate HyperNEAT parameters
InitialRes 8
DivisionThrs 10 
VarianceThr .03
BandingThr .3
ESIterations 1


Threshold defines the minimum value a CPPN must output for that 
connection to be expressed, should be 0-1.

WeightRange defines the minimum and maximum values for weights on substrate
connections, they go from -WeightRange to +WeightRange, and can be any integer.

NumberofThreads defines the number of simultaneous evaluations to run.  
This can be any integer greater than 0, however numbers greater than
the number of cores/processors you have available can degrade performance.
Note: Evolution with multiple threads is an experimental feature.

SubstrateActivationFunction determines which activation function each node
in the substrate will have.  This can be any of the activation functions in 
SharpNEATLib, you can add your own as well.  The activation function is the name of the 
.cs file containing that function (they are accessed by reflection, so case counts).

Activation Functions that can be in the CPPN start with 
"StartActivationFunctions" and are listed one per line and ended with 
"EndActivationFunctions".  Each activation function is the name of the .cs file
containing that function (they are accessed by reflection, so case counts) followed
by the probability of that function appearing.

The following parameters can be set to adjust ES-HyperNEAT:

InitialRes defines the initial ES-HyperNEAT sample resolution.

DivisionThrs defines the division threshold. If the variance in a region is greater than this value, after the initial resolution is reached, ES-HyperNEAT will sample down further (values greater than 1.0 will disable this feature). Note that sampling at really high resolutions can become computationally expensive. 

VarianceThr defines the variance threshold for the initial sampling.

BandingThr defines the threshold that determines when points are regarded to be in a band.

ESIterations defines how many time ES-HyperNEAT should iterativelty discover new hidden nodes.


COMMAND LINE
--------------
If called with the parameter "evolve" the command line tool is used. Otherwise the visual simulator is started.

The available command line parameters:

-experiment [filename]         	//Evolve using this experiment.
-homogenous [true/false]	//If true use homogenous teams otherwise heterogenous
-populationSize [number]
-generations [number]
-agent_count [number]
-novelty                     		//Use novelty search
-fitness_function [filename]
-hidden_density [number]     	//Specifies the number of hidden neurons
-input_density [number]      	//Specifies the number of input neurons
-rng_seed [number]           	//What random seed should be used.
-environment [filename]
-substrate [filename]
-eval [filename]             	//Evaluate the given genome and return fitness
-seed [filename]             	 //Seed evolution with the given genome
-folder [name]               	 //Output files to the specified folder
-multiobjective 		 //Turns on multiobjective search
-es [true/false]			 //Turn on/off evolvable-substrate HyperNEAT
-help 				//Shows the command line options


The command line tool will output genome files whenever a new champion is discovered. These genome files can be viewed in the visualizer. 

THE USER INTERFACE
---------------
The MultiAgent-HyperSharpNEAT Simulator GUI has 5 menus: File, Mode, Simulation, Evolution, and Help.

The File menu allows you to load and save experiments, genomes and environments. Included in this package is a representative sample individual evolved with ES Hyperneat. To run it, you must first load the appropriate experiment file (File->Load->Experiment), then load the genome file (File->Load->Genome). After both the experiment and genome are loaded, you can run the simulation through the Simulation>Run menu item.

It is important to note that the experiment file contains settings that determine how the genome file is interpreted. Running a genome in the context of an experiment file in which it was not evolved will often cause meaningless behavior. The following experiment files can be found the the �data� folder:

roomclear_exp_hetero.xml - MultiAgent HyperNEAT experiment file where robots cannot see each other

roomclear_exp_homo.xml - Homogeneous HyperNEAT experiment file where robots cannot see each other

hardmaze_exp.xml - Navigation Domain from the ES-HyperNEAT GECCO 2011 paper

patrol_switch.xml - Patrol and Return domain from the IROS 2011 paper where the team exploits situational policy geometry.

patrol_signal.xml - Patrol and Return domain from the IROS 2011 paper where the team does not exploit situational policy geometry.

The Mode menu allows you to change the current mode. The mode determines how mouse interaction will affect the environment.
Select mode: Agents and walls can be selected and moved to different locations by clicking and dragging with the left mouse button. This can be used as an experiment is running for interactive exploration of the evolved behaviors of the agents. Agents and walls can also be rotated by clicking and dragging with the right mouse button. 
Wall mode: By clicking and dragging with the left mouse button you can create a new wall.
Start Point, Goal Point, Point of Interest (POI), and Area of Interest (AOI) mode: A click on the environment places the corresponding object. The start point indicates where agents will begin in the environment, the goal point and POI (if used by the fitness function) indicate where agents should reach, and the AOI indicates for the room clearing experiment, what area of the environment should be covered by the agents.

The Simulation menu allows the user to run or reset the simulation (which will cause the agents to return to their initial starting locations). It also allows to explore the effects of scaling the team size (Simulation->Settings). Scaling to more agents with a homogeneous team (standard HyperNEAT) will add new agents with exactly the same policy, while scaling to more agents with multiagent HyperNEAT will add agents with different policies derived from their initial team geometry. You can also choose different fitness functions (which will influence what behaviors are rewarded when doing fitness-based evolution) , behavioral characterizations (which define the space of behaviors that novelty search will explore), robot models, change the number of rangefinders or turn evolvable-substrate/novelty search on and off. If fitness-based search is used (the novelty search item is not ticked), search will be guided by the chosen fitness function. If novelty search is used, search will depend on the chosen behavioral characterization.

The Evolution menu allows you to start evolution and to display the currently best performing genome. 

The Help menu offers an overview of the available key commands.

--------------
4. COMPILING
--------------

DEPENDENCIES
--------------
Everything necessary to compile the MultiAgent-HyperSharpNEAT Simulator is included in this release.

BUILD INSTRUCTIONS:
---------------
UNIX/LINUX/CYGWIN/MACOSX:

To run on these systems, compile and run with the latest version of Mono. You will need to run the executable (AgentSimulator.exe) from the data directory.

WINDOWS:

The included project files have everything set up to run in Microsoft Visual Studio 2008. To run from the command line the AgentSimulator.exe has to be in the same folder than the experiment/environment/genome files. If run from Visual Studio, set the working directory to the �data� directory.

--------------
5. EVOLVABLE-SUBTRATE EXAMPLE
--------------

To load the included ES-HyperNEAT example open the hardmaze_exp.xml (FIle->Open->Experiment) and load the following genome �hardmaze_example_genome.xml�. Then run the simulator (Simulation->Run). To view the evolved ANN select the agent and press �n�. To evolve a new genome for this experiment with the command line tool, run it with the following parameters �evolve -experiment hardmaze_exp.xml�. To run evolution directly from the GUI select Evolution->Start.

--------------
6. FORUM
--------------

We are available to answer questions at the NEAT Users Group:

http://tech.groups.yahoo.com/group/neat/

-------------------
7. ACKNOWLEDGEMENTS 
-------------------

Special thanks to Colin Green for creating SharpNEAT.
This work was supported by DARPA under grants HR0011-08-1-0020 and HR0011-09-1-0045 (Computer Science Study Group Phases I and II).