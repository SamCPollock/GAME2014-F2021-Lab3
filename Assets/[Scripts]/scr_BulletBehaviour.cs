using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_BulletBehaviour : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float speedValue;
    public scr_BulletManager bulletManager;
    public scr_Bounds bulletBounds;

    private void Start()
    {
        bulletManager = GameObject.FindObjectOfType<scr_BulletManager>();
    }


    void FixedUpdate()
    {
        transform.position += Vector3.down * speedValue;

        CheckBounds();
    }

    public void CheckBounds()
    {
        if (transform.position.y < bulletBounds.min)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
}
