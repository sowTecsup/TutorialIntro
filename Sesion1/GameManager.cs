using System.Collections.Generic;
using System;
using UnityEditor;
using UnityEngine;
using Sirenix.OdinInspector;
//using static Sowtank.GameUtils;
using static Sowtank.GameUtils;
using System.Linq;


public class GameManager : MonoBehaviour
{

   public int a = 10;
    public int b = 20;

    public string first = "Hola";
    public string second = "Mundo"; 

    void Start()
    {

        DiccionarioVida<string> enemigosVida = new();
        enemigosVida.AgregarEnemigo("Orco", 100);
        enemigosVida.AgregarEnemigo("Goblin", 50);

        enemigosVida.RecibirDaño("Orco", 30);
        Debug.Log("Vida actual del Orco: " 
            + enemigosVida.ObtenerVida("Orco"));


        GameObject jugador1 = new();
        GameObject jugador2 = new();

        DiccionarioVida<GameObject> jugadoresVida = new();
        jugadoresVida.AgregarEnemigo(jugador1, 200);
        jugadoresVida.AgregarEnemigo(jugador2, 150);

        jugadoresVida.RecibirDaño(jugador1, 50);
        Debug.Log("Vida actual del jugador 1: " 
            + jugadoresVida.ObtenerVida(jugador1));
    }

    [Button]
    public void ReadSwap()
    {
        Swap(ref a, ref b);
        Swap(ref first, ref second);

    }

    
    public void TransformAllExample1()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        List<string> strings = 
            TransformAll(numbers, n => n.ToString());
        foreach (var item in strings)      
           print(item); 
    }
    public void TransformAllExample2()
    {
        List<Enemies> Enemies = new();
        List<string> strings = 
            TransformAll(Enemies, n => n.MinionName);
        foreach (var item in strings)
        {
            print(item);
        }
    }
    public void TransformAllExample3()
    {
        List<player> players = new();
        List<int> scores =
            TransformAll(players, n => n.Score);
        scores.Sort();
        foreach (var item in scores)
        {
            print(item);
        }
    }

    public void TransforAllOutExample1()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5 };
        TransformAllOut(numbers, n => n.ToString(), out List<string> strings);

        TransformAllOut(numbers, n => n.ToString(), out _);
        foreach (var item in strings)
            print(item);

    }
   

    public void ApplyToAllExample1()
    {
        List<GameObject> enemigos = new();
        ApplyToAll(enemigos, e => e.SetActive(false));
    }
    public void ApplyToAllExample2()
    {
        List<String> enemigos = new();
        ApplyToAll(enemigos, e => e = "Null");
    }
    public void ApplyToAllExample3()
    {
        List<Enemies> enemigos = new();

        ApplyToAll(enemigos, e =>
        {
            if(e.Life < 24)
               e.ExcecuteEntity();
        });
    }
    public void ApplyDamage<T>
        (T enemy, int damage) 
        where T : Enemies
    {
        enemy.ExcecuteEntity();
    }

    public void ApplyDamageExample1()
    {
        List<OrcType> enemigos1 = new();
        List<GoblinType> enemigos2 = new();
        List<DemonType> enemigos3 = new();
   
        List<GameObject> allEnemies = enemigos1.Cast<GameObject>()
           .Concat(enemigos2.Cast<GameObject>())
           .Concat(enemigos3.Cast<GameObject>())
           .ToList();

        TransformAllOut(allEnemies, e => e.GetComponent<Enemies>(), 
            out List<Enemies> GeneralEnemis);

        ApplyToAll(GeneralEnemis, e =>
        {
            if (e.Life < 24)
                e.ExcecuteEntity();
        });

    }
    public class Enemies:MonoBehaviour
    {
        public string MinionName;
        public int Life = 100;
        public void ExcecuteEntity()
        {
            
        }
    }
    public class OrcType :Enemies
    {

    }
    public class GoblinType : Enemies
    {

    }
    public class DemonType : Enemies
    {

    }
    public class ClasePadre : MonoBehaviour
    {
        public int Life = 100;
        public void ExcecuteEntity()
        {

        }
    }
    public class player : MonoBehaviour
    {
        public int Score = 100;
        
    }
    public class ClaseHijo1 : ClasePadre
    {
        
    }
    public class ClaseHijo2 : ClasePadre
    {

    }
    void Update()
    {

    }
    
    /*
    Ahora ya tienes seis maneras distintas de usar métodos genéricos en C#
     : 1️ Restricción where T : ScriptName → Filtrar tipos válidos.
2️Uso de Action<T> → Aplicar una acción sin retorno.
3️ Uso de Func<T, TResult> → Transformar datos.
4️ Uso de out para obtener valores opcionales → Buscar elementos.
5️Uso de params → Aceptar múltiples elementos sin listas.
6️ Uso de IEnumerable<T> en lugar de List<T> → Hacer el código más flexible.*/
}
