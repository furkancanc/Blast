using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    protected abstract void LoadSprite(Sprite sprite);
    protected abstract void Configure();
}
