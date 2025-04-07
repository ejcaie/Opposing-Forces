using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform leftFlipper;
    public Transform rightFlipper;

    public Quaternion leftRotationStart;
    public Quaternion rightRotationStart;

    private Quaternion leftRotationTarget;
    private Quaternion rightRotationTarget;

    private void Start()
    {
        //leftRotationStart = leftFlipper.rotation;
        //rightRotationStart = rightFlipper.rotation;
}

    void Update()
    {
        Quaternion leftTarget = Quaternion.Euler(0, 0, 80);
        if (Input.GetKey(KeyCode.A) && leftFlipper.rotation.z < leftTarget.z)
        {
            leftFlipper.rotation = leftFlipper.rotation * Quaternion.Euler(0, 0, 0.8f);
        }
        else if (leftFlipper.rotation.z > 0)
        {
            leftFlipper.rotation = leftFlipper.rotation * Quaternion.Euler(0, 0, -1);
        }

        Quaternion rightTarget = Quaternion.Euler(0, 0, -80);
        if (Input.GetKey(KeyCode.D) && rightFlipper.rotation.z > rightTarget.z)
        {
            rightFlipper.rotation = rightFlipper.rotation * Quaternion.Euler(0, 0, -0.8f);
        }
        else if (rightFlipper.rotation.z < 0)
        {
            rightFlipper.rotation = rightFlipper.rotation * Quaternion.Euler(0, 0, 1);
        }
    }
}
