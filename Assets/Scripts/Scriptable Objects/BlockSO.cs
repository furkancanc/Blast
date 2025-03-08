using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Block ScriptableObject", order = 1)]
public class BlockSO : ScriptableObject
{
    [SerializeField] private Sprite[] blockSprites;

}
