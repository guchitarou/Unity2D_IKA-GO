using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aw : MonoBehaviour {
    public float speed=0.05f;
    int a=5;
    void FixedUpdate()
    {
        Vector2 tmp = this.transform.position;
        this.transform.position += new Vector3(speed, 0, 0);
        if (a == 0)
        {
            speed = -speed;
            a = 5;
        }
        a = a - 1;
        Invoke("DelayMethod", 7);
    }
    void DelayMethod()
    {
        Destroy(this.gameObject);
    }
}
