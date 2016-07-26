using UnityEngine;

public class Character : MonoBehaviour {
    private IWeapon weapon;

    private void Awake()
    {
        weapon = GetComponent<IWeapon>();
        if (weapon == null)
            Debug.LogWarning("This character doesn't have any weapon.");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            weapon.Shoot();
    }
}
