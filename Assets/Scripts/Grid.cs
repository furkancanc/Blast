using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private Vector2 gridSize;
    [SerializeField] Block[] blocks;

    public Vector2 GetGridSize()
    {
        return gridSize;
    }
    
}
