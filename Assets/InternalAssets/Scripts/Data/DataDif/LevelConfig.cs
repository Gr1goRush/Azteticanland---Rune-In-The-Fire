using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelConfig", menuName = "CreateLevelConfig")]
public class LevelConfig : ScriptableObject
{
    public int LevelID;
    public bool IsInfinity = false;
    
    [Space(30f)]
    [Header("CubeSettings")]
    public CubeSpritesPack CubeSpritesPack;
    
    [Tooltip("Скорость падения кубика")]
    public float CubeFallSpeed;

    [Header("FieldSettings"), Tooltip("Раз в сколько секунд появляются кубики снизу")]
    public float ShiftValuesPeriod;

    [Header("GoalSettings")]
    [Tooltip("Сколько раз нужно собрать цвета три в ряд")]
    public int[] CubeGoal;
    [Tooltip("Время за которое надо выйграть чтобы получить звезду")]
    public int TimeToGetStar;


    private void OnValidate()
    {
        if (CubeSpritesPack != null && CubeGoal.Length != CubeSpritesPack.CubeSprites.Length)
        {
            CubeGoal = new int[CubeSpritesPack.CubeSprites.Length];
        }

        if (CubeGoal != null)
        {
            CubeGoal[0] = 0;
        }
    }
}
