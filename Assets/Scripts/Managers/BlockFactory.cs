using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFactory : MonoBehaviour
{
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private BlockSO blockSO;
    
    public Cube SpawnCubeBlock(string blockType)
    {
        GameObject A = Instantiate(blockPrefab);
    }
}
