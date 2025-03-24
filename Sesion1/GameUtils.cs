using System.Collections.Generic;
using System;
using UnityEngine;

namespace Sowtank
{
    public static class GameUtils
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static List<T> SwapAndReturnList<T>( T a,  T b)
        {
            List<T> swappedList = new List<T> { b, a };
            return swappedList;
        }

        public static void ApplyToAll<T>(List<T> list, Action<T> action)
        {
            if (list == null) return;
            foreach (var item in list)
                action(item);
        }

        public static List<TResult> TransformAll<T, TResult>
        (List<T> list, Func<T, TResult> function)
        {
            List<TResult> result = new();
            foreach (var item in list)
            {
                result.Add(function(item));
            }
            return result;
        }

        public static void TransformAllOut<T, TResult>(
            List<T> list,
            Func<T, TResult> function,
            out List<TResult> convertList)
        {
            convertList = new();
            foreach (var item in list)
            {
                convertList.Add(function(item));
            }
        }
    }
}
public class DiccionarioVida<T>
{
    private List<T> claves = new();
    private List<int> valores = new();

    // Agrega un enemigo si no está en la lista
    public void AgregarEnemigo(T enemigo, int vidaInicial)
    {
        if (!claves.Contains(enemigo))
        {
            claves.Add(enemigo);
            valores.Add(vidaInicial);
        }
    }

    // Reduce la vida del enemigo y lo elimina si su vida llega a 0
    public void RecibirDaño(T enemigo, int daño)
    {
        int index = claves.IndexOf(enemigo);
        if (index != -1)
        {
            valores[index] -= daño;
            if (valores[index] <= 0)
            {
                claves.RemoveAt(index);
                valores.RemoveAt(index);
            }
        }
    }

    // Obtiene la vida actual del enemigo
    public int ObtenerVida(T enemigo)
    {
        int index = claves.IndexOf(enemigo);
        return (index != -1) ? valores[index] : -1;
    }
}
