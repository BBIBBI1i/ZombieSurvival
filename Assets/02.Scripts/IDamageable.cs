using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void onDamage(float damate, Vector3 hitpoins, Vector3 hitNoraml);
}
