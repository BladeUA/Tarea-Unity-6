using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    void AutoDestruction()
    {
        Destroy(this.gameObject);
    }
}
