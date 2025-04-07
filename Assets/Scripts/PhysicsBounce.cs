using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBounce : MonoBehaviour
{

    public Vector2 force = new Vector2 (100, 100);

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.AddForce(force);
    }
}
