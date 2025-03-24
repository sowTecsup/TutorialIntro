using UnityEngine;
using MoreMountains.Feedbacks;
using Sirenix.OdinInspector;
using static Doozy.Runtime.Colors.Models.RGB;

[CreateAssetMenu(fileName = "AlgoBehaviour", menuName = "Scriptable Objects/AlgoBehaviour")]


public class AlgoBehaviour : ScriptableObject
{
    public enum BehaviourType
    {
        Eat,//
        Run,//
        Attack,//
        Jump,//
        Cry,//
        Dance,//

        Sleep,// 
        Awake,
    }
    [FoldoutGroup("Settings"),SerializeField]
    public BehaviourType behaviourType;

    [FoldoutGroup("Settings"), SerializeField]
    private int duration;

    #region Health
    [FoldoutGroup("Settings"),ShowIf("@behaviourType == BehaviourType.Eat || behaviourType == BehaviourType.Sleep"),SerializeField]
    private int healthGain;
    #endregion

    #region Run
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Run"), SerializeField]
    private int speedBoost;
    #endregion

    #region Attack
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Attack"), SerializeField]
    private int damage;
    #endregion

    #region Jump
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Jump"), SerializeField]
    private int jumpForce;
    #endregion

    #region Cry
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Cry"), SerializeField]
    private int shieldAmount;
    #endregion

    #region Dance
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Dance"), SerializeField]
    private int taunt;
    #endregion

    #region Sleep
    [FoldoutGroup("Settings"), ShowIf("@behaviourType == BehaviourType.Dance"), SerializeField]
    private int staminaGain;
    #endregion

}
