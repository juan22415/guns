using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multigun : Gun {

    public override void Shoot()
    {
        base.Shoot(-1);
        base.Shoot(1);
    }
}
