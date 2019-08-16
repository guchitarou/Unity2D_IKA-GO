using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKA3 : MonoBehaviour {
    float x,y;
    public GameObject target;
    public SpriteRenderer sp2;
    // Use this for initialization
    void Start () {
        //this.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 tmp = target.transform.position;
        Vector2 my = this.gameObject.transform.position;
        x = tmp.x - my.x;
        y = tmp.y - my.y+0.04f;
        this.gameObject.transform.position = new Vector2(my.x+x, my.y + y);
    }
    void DelayMethod()
    {
        //this.gameObject.SetActive(false);
    }
}
