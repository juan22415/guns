using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private float damagePerHit = 10;

    [SerializeField]
    private float lifePoints = 100;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (collision.transform.tag == "Bullet")
        {
            Debug.Log("Bullet hit");
            MakeDamage();
            Destroy(collision.gameObject);
        }
    }

    private void MakeDamage()
    {
        lifePoints -= damagePerHit;
        if (lifePoints <= 0)
        {
            Debug.Log("Death");
            Destroy(gameObject);
        }
    }
}
