using System;
using UnityEngine;

[Serializable]
public struct Upgrade
{
    public int cost;
    [Range(0, 4)]
    public float incomeMultiplier;
}
