using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class AlgoPartResources : MonoBehaviour
{
   public List<AlgoPart> parts = new();

    public T GetPartWithOldestCode<T>(List<T> list) where T : AlgoPart
    {

        if (list == null || list.Count == 0)
        {
            Debug.LogError("This is not a part");
            return null;
        }

        T oldestPart = null;
        int oldestCode = int.MinValue;
        foreach (var part in list)
        {
            if (part != null && part.Code > oldestCode)
            {
                oldestCode = part.Code;
                oldestPart = part;
            }
        }
        return oldestPart;

    }
}
