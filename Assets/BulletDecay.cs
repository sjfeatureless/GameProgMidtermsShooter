using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDecay : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletDecay = 4f;

    void Start()
    {
        Destroy(gameObject, bulletDecay);
    }
}
