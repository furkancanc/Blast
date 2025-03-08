using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct LevelData
{
    public int level_number;
    public int grid_with;
    public int grid_height;
    public int move_count;
    public string[] grid;
}