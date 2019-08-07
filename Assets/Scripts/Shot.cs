using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform ShotPoint;

    public GameObject BulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(BulletPrefab,ShotPoint.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(100000f * transform.forward);
        }
    }
}
