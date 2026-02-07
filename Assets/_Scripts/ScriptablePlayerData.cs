using UnityEngine;

[CreateAssetMenu(fileName = "ScriptablePlayerData", menuName = "Scriptables/Player Data")]
public class ScriptablePlayerData : ScriptableObject
{
    public int totalXP;

    public void AddXP(int amount)
    {
        totalXP += amount;
    }
}
