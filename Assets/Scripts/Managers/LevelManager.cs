using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int CurrentLevel { get; private set; }
    public static Action onLevelGenerated;

    private void Awake()
    {
        CurrentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
    }

    private void Start()
    {
        
    }

    private bool TryReadLevelFromJson()
    {
        TextAsset levelText = Resources.Load<TextAsset>("Levels/Level" + CurrentLevel);
        if (levelText == null)
        {
            Debug.Log("");
            return false;
        }

        LevelData levelData = JsonUtility.FromJson<LevelData>(levelText.text);
        

        return true;
    }
}
