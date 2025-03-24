using UnityEngine;

public class AlgoPartDecoration : AlgoPart
{
    private AlgoPartType type = AlgoPartType.DECORATION;

    public AlgoPartDecoration(int code, string partName, string description) : base(code, partName, description)
    {
    }
}
