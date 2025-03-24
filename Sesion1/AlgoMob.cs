using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class AlgoMob : MonoBehaviour
{
    public enum EyeType
    {
        
    }
    public enum ColorType
    {

    }
    [FoldoutGroup("References"),SerializeField] private List<AlgoBehaviour> behaviours;
    [FoldoutGroup("References"), SerializeField] private AnimatorController animator;

    [FoldoutGroup("Settings"), SerializeField] private int health;
    [FoldoutGroup("Settings"), SerializeField] private int stamina;
    [FoldoutGroup("Settings"), SerializeField] private int speed;
    [FoldoutGroup("Settings"), SerializeField] private EyeType eyeType;
    [FoldoutGroup("Settings"), SerializeField] private ColorType colorType;


    private int currentHealth;

    

    public int Health => health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(int healAmount , int interval)
    {

    }
    public void SetAnimatinon(AlgoBehaviour.BehaviourType behaviourType)
    {
        animator.parameters[0].name = behaviourType.ToString();
    }

    public void AddBehaviour(AlgoBehaviour algoBehaviour)
    {

    }
}
