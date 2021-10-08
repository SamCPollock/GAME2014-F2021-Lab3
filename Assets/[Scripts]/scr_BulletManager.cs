using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class scr_BulletManager : MonoBehaviour
{
    public Queue<GameObject> bulletPool;
    public int maxBullets;
    public GameObject bulletPrefab;

    void Start()
    {
        bulletPool = new Queue<GameObject>();

        BuildBulletPool();
    }

 
    public void BuildBulletPool()
    {
        for (int i = 0; i < maxBullets; i++)
        {
            var temp_bullet = Instantiate(bulletPrefab);
            temp_bullet.SetActive(false);
            temp_bullet.transform.parent = transform;
            bulletPool.Enqueue(temp_bullet);
        }
    }

    public GameObject GetBullet(Vector2 position)
    {
        var temp_bullet = bulletPool.Dequeue();

        temp_bullet.transform.position = position;
        temp_bullet.SetActive(true);

        return temp_bullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);
    }
}
