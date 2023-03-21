using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnSphere : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 randomness;
    private void Start()
    {
        
    }
    public void OnClick()
    {
        randomness = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        Instantiate(Sphere, (transform.position + randomness), Quaternion.identity);
    }
}
