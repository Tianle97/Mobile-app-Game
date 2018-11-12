using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (BoxCollider2D))]
public class BulletDestroyed : MonoBehaviour {

	private void OnTrigerEnter2D(Collider2D collider2D)
    {
        Bullet bullet = collider2D.GetComponent<Bullet>();
        if(bullet)
        {
            Destroy(bullet.gameObject);
        }
    }
}
