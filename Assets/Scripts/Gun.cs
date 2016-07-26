﻿using UnityEngine;

public class Gun : MonoBehaviour, IWeapon {

    [SerializeField]
    private int capacity = 10;

    private int ammo;

    private void Start()
    {
        Reload();
    }

    public void Shoot()
    {
        if (ammo > 0)
        {
            ammo--;
            SpawnBullet();
        }
    }

    public void Reload()
    {
        ammo = capacity;
    }

    private void SpawnBullet()
    {
        Debug.Log("Shooting");
    }
}