using System;
using System.Collections;
using System.Collections.Generic;
namespace SharpNeatLib.Evolution
{
	public class NeatParameters
	{
		#region Constants

		public const int	DEFAULT_POPULATION_SIZE = 150;
        public const float  DEFAULT_P_INITIAL_POPULATION_INTERCONNECTIONS = 1.00F;//DAVID 0.05F;

		public const double DEFAULT_P_OFFSPRING_ASEXUAL = 0.5;
		public const double DEFAULT_P_OFFSPRING_SEXUAL = 0.5;
		public const double DEFAULT_P_INTERSPECIES_MATING = 0.01;

		public const double DEFAULT_P_DISJOINGEXCESSGENES_RECOMBINED = 0.1;

	//----- High level mutation proportions
		public const double DEFAULT_P_MUTATE_CONNECTION_WEIGHTS = 0.988;
        public const double DEFAULT_P_MUTATE_ADD_NODE = 0.002;
        public const double DEFAULT_P_MUTATE_ADD_MODULE = 0.0;
        public const double DEFAULT_P_MUTATE_ADD_CONNECTION = 0.02;
		public const double DEFAULT_P_MUTATE_DELETE_CONNECTION = 0.001;
		public const double DEFAULT_P_MUTATE_DELETE_SIMPLENEURON = 0.00;

//	//----- Secondary mutation proportions (Connection weight mutation).
//		public const double DEFAULT_P_MUTATE_CONNECTIONWEIGHT_JIGGLE_LARGEPROPORTION = 0.2;
//		public const double DEFAULT_P_MUTATE_CONNECTIONWEIGHT_JIGGLE_SMALLPROPORTION = 0.2;
//		public const double DEFAULT_P_MUTATE_CONNECTIONWEIGHT_JIGGLE_SINGLEWEIGHT = 0.2;
//		public const double DEFAULT_P_MUTATE_CONNECTIONWEIGHT_RESET_SMALLPROPORTION = 0.2;
//		public const double DEFAULT_P_MUTATE_CONNECTIONWEIGHT_RESET_SINGLEWEIGHT = 0.2;
//
//	//----- Tertiary mutation weight parameters.
//		public const double DEFAULT_P_CONNECTION_JIGGLE_LARGEPROPORTION = 0.5;
//		public const double DEFAULT_P_CONNECTION_JIGGLE_SMALLPROPORTION = 0.1;
//		public const double DEFAULT_P_CONNECTION_RESET_SMALLPROPORTION = 0.1;

	//-----
		public const double DEFAULT_COMPATIBILITY_THRESHOLD = 8 ;
		public const double DEFAULT_COMPATIBILITY_DISJOINT_COEFF = 1.0; 
		public const double DEFAULT_COMPATIBILITY_EXCESS_COEFF = 1.0; 
        // Schrum: The 2011 IROS paper with Situational Policy Geometry claims the weight coeff was 0.1
		public const double DEFAULT_COMPATIBILITY_WEIGHTDELTA_COEFF = 0.1; // 0.05; // Schrum: changed to match IROS 2011 

		public const double DEFAULT_ELITISM_PROPORTION = 0.2;
		public const double DEFAULT_SELECTION_PROPORTION = 0.2;

        public const int DEFAULT_TARGET_SPECIES_COUNT_MIN = 6;
		public const int DEFAULT_TARGET_SPECIES_COUNT_MAX = 10;

		public const int DEFAULT_SPECIES_DROPOFF_AGE = 200;

		public const int DEFAULT_PRUNINGPHASE_BEGIN_COMPLEXITY_THRESHOLD = 50;
		public const int DEFAULT_PRUNINGPHASE_BEGIN_FITNESS_STAGNATION_THRESHOLD = 10;
		public const int DEFAULT_PRUNINGPHASE_END_COMPLEXITY_STAGNATION_THRESHOLD = 15;

		public const double DEFAULT_CONNECTION_WEIGHT_RANGE = 10.0;
//		public const double DEFAULT_CONNECTION_MUTATION_SIGMA = 0.015;

        public const double DEFAULT_ACTIVATION_PROBABILITY = 1.0;

		#endregion

		#region Fields
		public double archiveThreshold=3.00;
        public int tournamentSize=4;
		public bool noveltySearch=false;
        public bool noveltyHistogram=false;
        public bool noveltyFixed=false;
        public bool noveltyFloat=false;
        public bool multiobjective=false;
	
        public List<int> histogramBins;
        
		public int populationSize;
		public float pInitialPopulationInterconnections;

		public double pOffspringAsexual;
		public double pOffspringSexual;
		public double pInterspeciesMating;

		/// <summary>
		/// The proportion of excess and disjoint genes used from the least fit parent during crossover.
		/// </summary>
		public double pDisjointExcessGenesRecombined;

	//----- High level mutation proportions
		public double pMutateConnectionWeights;
        public double pMutateAddNode;
        public double pMutateAddModule;
        public double pMutateAddConnection;
		public double pMutateDeleteConnection;
		public double pMutateDeleteSimpleNeuron;

        // Schrum: Added to handle module mutation
        public double pMMP;
        public double pMMR;
        public double pMMD;

		/// <summary>
		/// A list of ConnectionMutationParameterGroup objects to drive the types of connection mutation
		/// that occur.
		/// </summary>
		public ConnectionMutationParameterGroupList ConnectionMutationParameterGroupList;

	//-----
		public double compatibilityThreshold;
		public double compatibilityDisjointCoeff;
		public double compatibilityExcessCoeff;
		public double compatibilityWeightDeltaCoeff;

		/// <summary>
		/// The proportion of best genomes from the parent generation to keep in the following generation.
		/// </summary>
		public double elitismProportion;

		/// <summary>
		/// Similar to the elitist proportion. This is the proportion of genomes from a species that we select
		/// from when creating offspring. The top n% genomes are selected from.
		/// </summary>
		public double selectionProportion;

		public int targetSpeciesCountMin;
		public int targetSpeciesCountMax;

		public int speciesDropoffAge;

		/// <summary>
		/// The complexity at which pruning phase should begin. The actual threshold is calculted by adding this
		/// number to the average complexity of the population at the end of the previous prune phase.
		/// </summary>
		public float pruningPhaseBeginComplexityThreshold;

		/// <summary>
		/// The minimum amount of fitness stagnation (measured in generations) that must have occured before pruning 
		/// phase can begin. E.g. consider that pruningPhaseBeginComplexityThreshold has been passed. We do not 
		/// enter prune phase until this threshold has also been met, that way we wait for the population to stop improving
		/// before we start pruning.
		/// </summary>
		public int pruningPhaseBeginFitnessStagnationThreshold;

		/// <summary>
		/// When in pruning mode the avg population complexity will drop. We wait for 'pruningPhaseEndComplexityStagnationThreshold'
		/// generations of no complexity drop before ending a pruning phase.
		/// </summary>
		public int pruningPhaseEndComplexityStagnationThreshold;

		public double connectionWeightRange;

        //DAVID
        public double[] activationProbabilities;
		
		#endregion

		#region Constructor

		/// <summary>
		/// Default Constructor.
		/// </summary>
		public NeatParameters()
		{
            // Schrum: Default Module Mutation rates are 0.0 ... it is never on by default
            pMMP = 0.0;
            pMMR = 0.0;
            pMMD = 0.0;

		    histogramBins = new List<int>();
		    
		    noveltySearch = false;
		    noveltyHistogram = false;
		    noveltyFixed = false;
		    noveltyFloat = false;
		    
			populationSize = DEFAULT_POPULATION_SIZE;
			pInitialPopulationInterconnections = DEFAULT_P_INITIAL_POPULATION_INTERCONNECTIONS;

			pOffspringAsexual = DEFAULT_P_OFFSPRING_ASEXUAL;
			pOffspringSexual = DEFAULT_P_OFFSPRING_SEXUAL;
			pInterspeciesMating = DEFAULT_P_INTERSPECIES_MATING;

			pDisjointExcessGenesRecombined = DEFAULT_P_DISJOINGEXCESSGENES_RECOMBINED;

//			pMutateConnectionWeights = DEFAULT_P_MUTATE_CONNECTION_WEIGHTS;
//			pMutateAddNode = DEFAULT_P_MUTATE_ADD_NODE;
//			pMutateAddConnection = DEFAULT_P_MUTATE_ADD_CONNECTION;
//			pMutateDeleteConnection = DEFAULT_P_MUTATE_DELETE_CONNECTION;
//			pMutateDeleteSimpleNeuron = DEFAULT_P_MUTATE_DELETE_SIMPLENEURON;

		//----- High level mutation proportions
			pMutateConnectionWeights	= DEFAULT_P_MUTATE_CONNECTION_WEIGHTS;
            pMutateAddNode = DEFAULT_P_MUTATE_ADD_NODE;
            pMutateAddModule = DEFAULT_P_MUTATE_ADD_MODULE;
            pMutateAddConnection = DEFAULT_P_MUTATE_ADD_CONNECTION;
			pMutateDeleteConnection		= DEFAULT_P_MUTATE_DELETE_CONNECTION;
			pMutateDeleteSimpleNeuron	= DEFAULT_P_MUTATE_DELETE_SIMPLENEURON;

		//----- Build a default ConnectionMutationParameterGroupList.
			ConnectionMutationParameterGroupList = new ConnectionMutationParameterGroupList();
			ConnectionMutationParameterGroupList.Add(new ConnectionMutationParameterGroup(0.125, ConnectionPerturbationType.JiggleEven, ConnectionSelectionType.Proportional, 0.5, 0, 0.05, 0.0));
			ConnectionMutationParameterGroupList.Add(new ConnectionMutationParameterGroup(0.125, ConnectionPerturbationType.JiggleEven, ConnectionSelectionType.Proportional, 0.1, 0, 0.05, 0.0));
			ConnectionMutationParameterGroupList.Add(new ConnectionMutationParameterGroup(0.125, ConnectionPerturbationType.JiggleEven, ConnectionSelectionType.FixedQuantity, 0.0, 1, 0.05, 0.0));	
			ConnectionMutationParameterGroupList.Add(new ConnectionMutationParameterGroup(0.5, ConnectionPerturbationType.Reset, ConnectionSelectionType.Proportional, 0.1, 0, 0.0, 0.0));	
			ConnectionMutationParameterGroupList.Add(new ConnectionMutationParameterGroup(0.125, ConnectionPerturbationType.Reset, ConnectionSelectionType.FixedQuantity, 0.0, 1, 0.0, 0.0));	

		//-----
			compatibilityThreshold = DEFAULT_COMPATIBILITY_THRESHOLD;
			compatibilityDisjointCoeff = DEFAULT_COMPATIBILITY_DISJOINT_COEFF;
			compatibilityExcessCoeff = DEFAULT_COMPATIBILITY_EXCESS_COEFF;
			compatibilityWeightDeltaCoeff = DEFAULT_COMPATIBILITY_WEIGHTDELTA_COEFF;

			elitismProportion = DEFAULT_ELITISM_PROPORTION;
			selectionProportion = DEFAULT_SELECTION_PROPORTION;

			targetSpeciesCountMin = DEFAULT_TARGET_SPECIES_COUNT_MIN;
			targetSpeciesCountMax = DEFAULT_TARGET_SPECIES_COUNT_MAX;

			pruningPhaseBeginComplexityThreshold = DEFAULT_PRUNINGPHASE_BEGIN_COMPLEXITY_THRESHOLD;
			pruningPhaseBeginFitnessStagnationThreshold = DEFAULT_PRUNINGPHASE_BEGIN_FITNESS_STAGNATION_THRESHOLD;
			pruningPhaseEndComplexityStagnationThreshold = DEFAULT_PRUNINGPHASE_END_COMPLEXITY_STAGNATION_THRESHOLD;

			speciesDropoffAge = DEFAULT_SPECIES_DROPOFF_AGE;

			connectionWeightRange = DEFAULT_CONNECTION_WEIGHT_RANGE;

            //DAVID
            activationProbabilities = new double[4];
            activationProbabilities[0] = DEFAULT_ACTIVATION_PROBABILITY;
            activationProbabilities[1] = 0;
            activationProbabilities[2] = 0;
            activationProbabilities[3] = 0;
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="copyFrom"></param>
		public NeatParameters(NeatParameters copyFrom)
		{
            // Schrum: Added
            pMMP = copyFrom.pMMP;
            pMMR = copyFrom.pMMR;
            pMMD = copyFrom.pMMD;

		    //joel
		    noveltySearch = copyFrom.noveltySearch;
		    noveltyHistogram = copyFrom.noveltyHistogram;
		    noveltyFixed = copyFrom.noveltyFixed;
		    noveltyFloat = copyFrom.noveltyFloat;
		    histogramBins = copyFrom.histogramBins;
		    
			populationSize = copyFrom.populationSize;

			pOffspringAsexual = copyFrom.pOffspringAsexual;
			pOffspringSexual = copyFrom.pOffspringSexual;
			pInterspeciesMating = copyFrom.pInterspeciesMating;

			pDisjointExcessGenesRecombined = copyFrom.pDisjointExcessGenesRecombined;

			pMutateConnectionWeights = copyFrom.pMutateConnectionWeights;
            pMutateAddNode = copyFrom.pMutateAddNode;
            pMutateAddModule = copyFrom.pMutateAddModule;
            pMutateAddConnection = copyFrom.pMutateAddConnection;
			pMutateDeleteConnection = copyFrom.pMutateDeleteConnection;
			pMutateDeleteSimpleNeuron = copyFrom.pMutateDeleteSimpleNeuron;

			// Copy the list.
			ConnectionMutationParameterGroupList = new ConnectionMutationParameterGroupList(copyFrom.ConnectionMutationParameterGroupList);

			compatibilityThreshold = copyFrom.compatibilityThreshold;
			compatibilityDisjointCoeff = copyFrom.compatibilityDisjointCoeff;
			compatibilityExcessCoeff = copyFrom.compatibilityExcessCoeff;
			compatibilityWeightDeltaCoeff = copyFrom.compatibilityWeightDeltaCoeff;

			elitismProportion = copyFrom.elitismProportion;
			selectionProportion = copyFrom.selectionProportion;

			targetSpeciesCountMin = copyFrom.targetSpeciesCountMin;
			targetSpeciesCountMax = copyFrom.targetSpeciesCountMax;

			pruningPhaseBeginComplexityThreshold = copyFrom.pruningPhaseBeginComplexityThreshold;
			pruningPhaseBeginFitnessStagnationThreshold = copyFrom.pruningPhaseBeginFitnessStagnationThreshold;
			pruningPhaseEndComplexityStagnationThreshold = copyFrom.pruningPhaseEndComplexityStagnationThreshold;

			speciesDropoffAge = copyFrom.speciesDropoffAge;

			connectionWeightRange = copyFrom.connectionWeightRange;
		}

		#endregion
	}
}
