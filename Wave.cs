using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Wave : MonoBehaviour {
    GameObject Cm;
    float x,y,x1;
    GameObject coin,root;
    public GameObject[] player;
    public GameObject killer;
    Jowa jo;
    int point,i;
    Saver sv;

    private void Start()
    {
        root = GameObject.Find("root");
        coin = GameObject.Find("Canvas/Text");
        jo = GetComponent<Jowa>();
    }

    void FixedUpdate()
    {
        Vector2 tmp = GameObject.Find("MainCamera1").transform.position;
        Vector2 my=this.gameObject.transform.position;
        Vector2 my2 = killer.gameObject.transform.position;
        x = tmp.y-my.y-7;
        this.gameObject.transform.position = new Vector2(my.x , my.y+x);
        x1 = tmp.y - my2.y-5;
        if (x1 > 0)
        {
            killer.gameObject.transform.position= new Vector2(my2.x, my2.y + x1);
        }

    }

    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Ch")
        {
            Vector2 tmp = this.gameObject.transform.position;
            y = tmp.y;
            jo.Newwave(y);
            Destroy(c.gameObject);

        }
        if (c.tag == "desika")
        {
            Debug.Log("Ded!!!");
        }
        Destroy(c.gameObject);
    }
}
