namespace Domain.Interface
{

    public interface IProbabilityCalculationService
    {
        double CalculateProbability(double mean, double standardDeviation, double value);
    }

}