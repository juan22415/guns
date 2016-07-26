using UnityEngine;

public class Character : MonoBehaviour {
    private IWeapon[] weapons;
    private int current = 0;

    private void Awake()
    {
        weapons = GetComponents<IWeapon>();
        if (weapons == null)
            Debug.LogWarning("This character doesn't have any weapon.");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            weapons [current].Shoot();
        if (Input.GetButtonDown("Change Weapon"))
            ChangeWeapon();
    }

    private void ChangeWeapon(int selected)
    {
        current = selected;
    }

    private void ChangeWeapon()
    {
        int selected = (current + 1) % weapons.Length;
        ChangeWeapon(selected);
    }
}
