using UnityEngine;

public class EasyBall : Entities
{
    [HideInInspector] public float speed;
    [HideInInspector] public Vector3 despawnPoint;
    [HideInInspector] public int xpReward;
    [HideInInspector] public float health;

    public void Initialize(Vector3 despawnPoint, float speed, float health, int xpReward)
    {
        this.despawnPoint = despawnPoint;
        this.speed = speed;
        this.health = health;
        this.xpReward = xpReward;
    }

    public override void Move()
    {
        if (despawnPoint == null) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            despawnPoint,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, despawnPoint) < 0.05f)
        {
            Destroy(gameObject);
        }
    }

    public override void OnRayHit(float damage)
    {
        if (health >= 0)
        {
            XPManager.Instance.AddXP(1);
            Destroy(gameObject);
            return;
        }

        TakeDamange(damage);
    }
    public void TakeDamange(float amount)
    {
        health -= amount;
    }

    private void OnDestroy()
    {
        MovementSystem.Instance.UnregisterSphere(this);
    }
}
