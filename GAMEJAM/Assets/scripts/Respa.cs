using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respa : MonoBehaviour
{
    public GameObject enemy;
    float randx;
    float randy;
    Vector2 wheretospawn;
    public float spawnrate = 1f;
    float nextspawn = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextspawn)
        {
            nextspawn = Time.time + spawnrate;
            randx = Random.Range(-18.9f, 7.8f);
            randy = Random.Range(-18.9f, 7.8f);
            wheretospawn = new Vector2(randx, transform.position.x);
            Instantiate(enemy,wheretospawn,Quaternion.identity);
        }
    }
}
