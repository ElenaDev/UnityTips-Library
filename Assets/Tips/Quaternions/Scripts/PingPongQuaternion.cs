using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongQuaternion : MonoBehaviour
{
    [SerializeField] private float speed;

    private float t;
    
    void Update()
    {
        Quaternion rotFrom = Quaternion.Euler(0, 0, 0);
        Quaternion rotTo = Quaternion.Euler(45, 0, 0);

        t = Mathf.PingPong(Time.time * speed, 1.0f);

        transform.rotation = Quaternion.Slerp(rotFrom, rotTo, t);
    }
}
