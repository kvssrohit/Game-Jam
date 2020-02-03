using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    public Transform player;
    public float speed = 10.0f;
    public GameObject bulletprefab;
    public AudioClip SingleShoot;
    public AudioSource au;
    private void Start()
    {
        au = GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }
        transform.position = pos;
        

    }
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletprefab) as GameObject;
        b.transform.position = player.transform.position;
        au.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(gameObject);
        }
    }
}
