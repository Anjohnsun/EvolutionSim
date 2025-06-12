using Interfaces.Dto;

namespace Interfaces;

public interface ISimulationDataProvider
{
    void SendSimulationData(IndividDto[] individs, LightSourceDto[] lightSources);
}
