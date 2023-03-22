using System;
using UnityEngine;

[Serializable]
public struct Upgrade
{
    public int cost;
    public float incomeMultiplier;
}

[CreateAssetMenu(fileName = "Business config", menuName = "Configs/Business config", order = 1)]
public class BusinessConfg : ScriptableObject
{
    public int level;
    public int incomeDelay;
    public int baseCost;
    public int baseIncome;

    public Upgrade upgradeOne;
    public Upgrade upgradeTwo;

    public int GetIncome()
    {
        int income = level * baseIncome * (int)(1 + upgradeOne.incomeMultiplier + upgradeTwo.incomeMultiplier);
        return income;
    }

    public int GetUpgradeCost()
    {
        int cost = (level + 1) * baseCost;
        return cost;
    }
}
