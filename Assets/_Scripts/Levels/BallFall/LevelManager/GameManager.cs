using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool IsMovementAllowed { get; private set; }

    [SerializeField] private CountDown countDown;
    [SerializeField] private EntitySpawner spawner;
    [SerializeField] private Timer timer;

    private void Start()
    {
        IsMovementAllowed = false;
        spawner.enabled = false;

        countDown.StartCountdown(OnCountdownFinished);
    }

    private void OnCountdownFinished()
    {
        IsMovementAllowed = true;
        spawner.StartSpawning();
        timer.StartTimer();
    }
}
