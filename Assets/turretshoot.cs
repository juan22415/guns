using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretshoot : MonoBehaviour {

    private IWeapon[] weapons;

    private float timer;
    private int current = 0;

    private void Awake()
    {
        weapons = GetComponents<IWeapon>();
        if (weapons == null)
            Debug.LogWarning("This character doesn't have any weapon.");
    }

    // Use this for initialization
   
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer>1)
        {
            weapons[current].Shoot();
            timer = 0;
        }
		
	}
}
