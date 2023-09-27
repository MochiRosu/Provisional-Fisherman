using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float cooldownTime = 1.0f; // Adjust this value to set the cooldown time between shots.
    private float cooldownTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        // Update the cooldown timer.
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }

        // Check if the player can fire (cooldown timer has expired).
        if (Input.GetButtonDown("Fire1") && cooldownTimer <= 0)
        {
            // Instantiate the projectile and reset the cooldown timer.
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            cooldownTimer = cooldownTime; // Reset the cooldown timer.
        }
    }
}
