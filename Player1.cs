using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IKA2 : MonoBehaviour {
    public float life = 0.3f;
    public AudioSource sound01, sound02;
    public Rigidbody2D rb2d;
    public SpriteRenderer sp;
    SpriteRenderer sp2;
    GameObject obj1, obj2, root, coin;
    public float flap = 5f;
    int r, g, b;
    public GameObject NEWIKA1, desika;
    Saver sv;
    int k = 1, ch = 1, point, l=1;
    float x, y;
    Score Sc;
    // Use this for initialization
    GameObject MainCamera2;
    void Start () {
        Time.timeScale = 1;
        r =PlayerPrefs.GetInt("R");
        g=PlayerPrefs.GetInt("G");
        b=PlayerPrefs.GetInt("B");
        rb2d = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        NEWIKA1.gameObject.SetActive(false);
        Sc = GetComponent<Score>();
        sv = GetComponent<Saver>();
        MainCamera2 = GameObject.Find("/root/MainCamera1");
        MainCamera2.transform.parent = this.gameObject.transform;
        sp.color = new Color(r, g, b);
    }
	// Update is called once per frame
	void Update () {
        Vector2 my = NEWIKA1.transform.position;
        Vector2 tmp = this.gameObject.transform.position;
        x = tmp.x - my.x;
        y = tmp.y - my.y + 0.04f;
        NEWIKA1.gameObject.transform.position = new Vector2(my.x + x, my.y + y);
        if (l == 0)
        {
            sp.color = new Color(0, 0, 0, 0);
        }
        else if ((l==1)&&(Input.GetMouseButtonDown(0)))
        {   
            rb2d.AddForce(Vector2.up * flap);
            sound01.PlayOneShot(sound01.clip);
            sp.color= new Color(0, 0, 0, 0);
            NEWIKA1.gameObject.SetActive(true);
            Invoke("DelayMethod", 0.7f);
        }        
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Enemy")
        {
            sp.color = new Color(0, 0, 0, 0);
            NEWIKA1.gameObject.SetActive(false);
            if (l == 1)
            {
                Instantiate(desika, this.transform.position, this.transform.rotation);
            }
            l = 0;
            Invoke("Ded", 1);
        }
        if (c.tag == "Coin")
        {
            sound02.PlayOneShot(sound02.clip);
            Destroy(c.gameObject);
            point = Sc.score+0;
            point = point + 1;
            Sc.add(point);
        }
    }
    void DelayMethod()
    {
        if (l == 1)
        {
            sp.color = new Color(r, g, b);
        }
        
        NEWIKA1.gameObject.SetActive(false);
    }
    void Ded()
    {
        point = Sc.score;
        sv.Save(point);
        SceneManager.LoadScene("Gameover");
    }
}
