using System;
using System.Collections.Generic;
using Domain.Model;

using Domain.Interface;

namespace CinpBLL;

public class ProbabilityCalculationService : IProbabilityCalculationService
{
    public double CalculateProbability(double mean, double standardDeviation, double value)
    {
        // Calculate the z-score
    
     throw new NotImplementedException();

    }

    public double CalculateCorrelation (List<double> Xvalues, List<double> Yvalues)
    {
        if (Xvalues.Count != Yvalues.Count)
        {
            throw new ArgumentException("The lengths of the input lists must be equal.");
        }
      

        int n = Xvalues.Count;
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0, sumY2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumX += Xvalues[i];
            sumY += Yvalues[i];
            sumXY += Xvalues[i] * Yvalues[i];
            sumX2 += Xvalues[i] * Xvalues[i];
            sumY2 += Yvalues[i] * Yvalues[i];
        }

        double numerator = n * sumXY - sumX * sumY;
        double denominator = Math.Sqrt((n * sumX2 - sumX * sumX) * (n * sumY2 - sumY * sumY));

        if (denominator == 0)
        {
            throw new InvalidOperationException("Denominator is zero, correlation cannot be calculated.");
        }

        return numerator / denominator;
    }

    //bayesian probability calculation
    public double CalculateBayesianProbability(double ProbablityOfEventA , double likelihoodBGivenA, double ProbablityOfEventB)
    {
        if (ProbablityOfEventB == 0)
        {
            throw new InvalidOperationException("Probability of Event B cannot be zero.");
        }

        return (ProbablityOfEventA * likelihoodBGivenA) / ProbablityOfEventB;
    }
  


}
