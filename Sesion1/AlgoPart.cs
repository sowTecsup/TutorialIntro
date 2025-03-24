using UnityEngine;


public enum AlgoPartType
{
    EYES,
    BODY,
    DECORATION
}
public class AlgoPart : MonoBehaviour
{
    private int code;
    private string partName;
    private string description;

    public AlgoPart(int code = 0, string partName = "none", string description = "none")
    {
        this.code = code;
        this.partName = partName;
        this.description = description;
    }
    public int Code => code;
    public string PartName => partName;
    public string Description => description;

    public virtual void GetName()
    {
        Debug.Log("Part Name: " + partName);
    }
}
