using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourcesManager
{
    [Header("Data")]
    const string blueCubeDataPath = "Sprites/Cubes/CubeBlue";
    const string greenCubeDataPath = "Sprites/Cubes/CubeGreen";
    const string purpleCubeDataPath = "Sprites/Cubes/cubePurple";
    const string redCubeDataPath = "Sprites/Cubes/cubeRed";
    const string yellowCubeDataPath = "Sprites/Cubes/cubeYellow";

    public static Sprite GetCubeSpite(CubeTypes cubeType)
    {
        Sprite cubeSprite = null;

        switch (cubeType)
        {
            case CubeTypes.Blue:
                cubeSprite = Resources.Load<Sprite>(blueCubeDataPath);
                break;
            case CubeTypes.Green:
                cubeSprite = Resources.Load<Sprite>(greenCubeDataPath);
                break;
            case CubeTypes.Purple:
                cubeSprite = Resources.Load<Sprite>(purpleCubeDataPath);
                break;
            case CubeTypes.Red:
                cubeSprite = Resources.Load<Sprite>(redCubeDataPath);
                break;
            case CubeTypes.Yellow:
                cubeSprite = Resources.Load<Sprite>(yellowCubeDataPath);
                break;
        }

        return cubeSprite;
    }
}
