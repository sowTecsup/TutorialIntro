using System;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    void Start()
    {
        List<int> list = new List<int>();  
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        Queue<int> queue = new Queue<int>();
        int searchValue = 99999999;

        // Poblar estructuras con 100,000 elementos
        for (int i = 0; i < 100000000; i++)
        {
            list.Add(i);
            dictionary.Add(i, i);
        }

        // Medir tiempo de búsqueda en lista (O(n))
        double startTime = Time.realtimeSinceStartup;
        bool foundInList = list.Contains(searchValue);
        double listTime = Time.realtimeSinceStartup - startTime;

        // Medir tiempo de búsqueda en diccionario (O(1))
        startTime = Time.realtimeSinceStartup;
        bool foundInDict = dictionary.ContainsKey(searchValue);
        double dictTime = Time.realtimeSinceStartup - startTime;

        Debug.Log($"Tiempo de búsqueda en List: {listTime} segundos");
        Debug.Log($"Tiempo de búsqueda en Dictionary: {dictTime} segundos");
    }
}
