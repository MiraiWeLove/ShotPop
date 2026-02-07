using UnityEngine;

public class XPManager : MonoBehaviour
{
    public static XPManager Instance;

    [Header("Player Stats")]
    [SerializeField] public int currentXP = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddXP(int amount) 
    {
        currentXP += amount;
    }

}
