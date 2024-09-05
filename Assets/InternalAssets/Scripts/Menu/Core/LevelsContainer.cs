using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsContainer : MonoBehaviour
{
    public static LevelsContainer instance;
    [SerializeField] private LevelConfig[] _levels;
    public LevelConfig[] Levels => _levels;

    private void Start()
    {
        instance = this;
    }
}
