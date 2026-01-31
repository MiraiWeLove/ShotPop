using UnityEngine;
using System.Collections;

public class EntitySpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private EasyBall easyBallPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform despawnPoint;
    [SerializeField] private Transform entitiesParent;
    [SerializeField] private MovementSystem movementSystem;

    [Header("Spawn Settings")]
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float spawnRange = 5f;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float health = 10f;
    [SerializeField] private int xpReward = 1;

    private Coroutine spawnRoutine;

    private void Awake()
    {
        if (!easyBallPrefab || !spawnPoint || !despawnPoint || !movementSystem)
        {
            Debug.LogError("EntitySpawner: Missing references", this);
            enabled = false;
        }
    }

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnLoop());
    }

    private void OnDisable()
    {
        if (spawnRoutine != null)
            StopCoroutine(spawnRoutine);
    }

    private IEnumerator SpawnLoop()
    {
        var wait = new WaitForSeconds(spawnInterval);

        while (true)
        {
            SpawnEntity();                                                                                                                                                                                                                      
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnEntity()
    {
        Vector3 spawnPos = GetRandomSpawnPoint();

        EasyBall sphere = Instantiate(
            easyBallPrefab,
            spawnPos,
            Quaternion.identity,
            entitiesParent
        );


        Vector3 targetDespawnPoint = new Vector3(
            spawnPos.x,
            despawnPoint.position.y,
            despawnPoint.position.z
        );

        sphere.Initialize(targetDespawnPoint, speed, health, xpReward);
        movementSystem.RegisterSphere(sphere);
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float x = Random.Range(
            spawnPoint.position.x - spawnRange,
            spawnPoint.position.x + spawnRange
        );

        return new Vector3(x, spawnPoint.position.y, spawnPoint.position.z);
    }






















    private void OnDrawGizmos()
    {
        if (!spawnPoint || !despawnPoint) return;

        DrawLine(spawnPoint.position, Color.green);
        DrawLine(despawnPoint.position, Color.red);
    }

    private void DrawLine(Vector3 center, Color color)
    {
        Gizmos.color = color;

        Vector3 left = center + Vector3.left * spawnRange;
        Vector3 right = center + Vector3.right * spawnRange;

        Gizmos.DrawLine(left, right);
    }
}