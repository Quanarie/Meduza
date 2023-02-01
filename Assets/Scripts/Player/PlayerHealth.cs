using UnityEngine;

public class PlayerHealth : Health
{
    private Vector3 startPos;

    protected override void Start()
    {
        base.Start();
        startPos = transform.position;
    }

    protected override void Death()
    {
        Respawn();
    }

    private void Respawn()
    {
        currentHitPoints = maxHitPoints;
        transform.position = startPos;
    }
}