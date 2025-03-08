using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Transform spawnedBlocksParent;
    [SerializeField] private SpriteRenderer border;
    private Grid grid;

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        SetBorderSize();
    }

    private void SetBorderSize()
    {
        //Vector2 gridSize = grid.GetGridSize();

        Vector2 gridSize = new Vector2(7, 7);

        float blockSize = .5f;
        float gapSize = .05f;

        border.transform.localScale = new Vector3((blockSize + gapSize) * gridSize.x, (blockSize + gapSize) * gridSize.y, 1);
    }

    private void SetGridLayout()
    {

    }
}
