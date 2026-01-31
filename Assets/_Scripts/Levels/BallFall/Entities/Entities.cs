using UnityEngine;

public abstract class Entities : MonoBehaviour
{
    public abstract void OnRayHit(float damage);
    public abstract void Move();
}
