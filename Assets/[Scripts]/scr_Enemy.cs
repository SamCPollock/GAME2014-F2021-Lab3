using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Enemy : MonoBehaviour
{

    public float randomSpeed;
 
    [Header("Enemy Movement")]
    public scr_Bounds movementBounds;
    public scr_Bounds startingRange;


    [Header("Bullets")]
    public scr_BulletManager bulletManager;
    public float startingPoint;
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public int frameDelay = 10;

    void Start()
    {
        randomSpeed = Random.Range(movementBounds.min, movementBounds.max);
        startingPoint = Random.Range(startingRange.min, startingRange.max);
        bulletManager = GameObject.FindObjectOfType<scr_BulletManager>();
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, randomSpeed) + startingPoint, transform.position.y);

        // Bullet spawning: 
        if(Time.frameCount % frameDelay == 0)
        {

            //var temp_bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
            //temp_bullet.
            bulletManager.GetBullet(bulletSpawn.position);
        }

        //transform.position = new Vector3(Mathf.PingPong(Time.time, randomSpeed) + startingPoint, transform.position.y, transform.position.z);
    }
}
