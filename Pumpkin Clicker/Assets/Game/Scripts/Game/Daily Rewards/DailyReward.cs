using UnityEngine;

[System.Serializable]
public struct DailyReward
{
    public DailyRewardType RewardType;
    public double Amount;
    public Sprite Icon;
    public int UpgradeIndex;
} 
