using UnityEngine;

public class Gun : MonoBehaviour, IWeapon {

    [SerializeField]
    private int capacity = 10;

    [SerializeField]
    private Rigidbody bullet;

    [SerializeField]
    private float velocity;

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
        Rigidbody shot = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        shot.AddForce(transform.forward * velocity);
    }
}
