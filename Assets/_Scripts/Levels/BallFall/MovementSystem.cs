using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    public static MovementSystem Instance;

    private List<Entities> entities = new List<Entities>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
    }

    public void RegisterSphere(Entities sphere)
    {
        entities.Add(sphere);
    }

    public void UnregisterSphere(Entities sphere)
    {
        entities.Remove(sphere);
    }

    private void Update()
    {
        if (!GameManager.IsMovementAllowed) return;

        for (int i = entities.Count - 1; i >= 0; i--)
        {
            entities[i].Move();
        }
    }
}