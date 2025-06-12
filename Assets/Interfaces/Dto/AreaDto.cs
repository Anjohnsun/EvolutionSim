namespace Interfaces.Dto;

internal class AreaDto
{
    public CellDto[] Cells { get; }
    public LightSourceDto[] LightSources { get; }

    public AreaDto(CellDto[] cells, LightSourceDto[] lightSources)
    {
        Cells = cells;
        LightSources = lightSources;
    }
}
