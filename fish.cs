using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour {

    public float speed = 10, life = 1.0f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = this.gameObject.transform.right.normalized * speed;
        Invoke("DelayMethod", life);
    }
    void DelayMethod()
    {
        Destroy(this.gameObject);
    }
    
}
