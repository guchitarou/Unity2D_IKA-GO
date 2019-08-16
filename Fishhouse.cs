using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishhouse : MonoBehaviour
{
    public GameObject bullet;
    GameObject obj;
    public float i;
    IEnumerator Start()
    {
        while (true)
        {
            // 弾をプレイヤーと同じ位置/角度で作成
            obj = Instantiate(bullet, transform.position, transform.rotation);
            obj.transform.parent = this.gameObject.transform;
            yield return new WaitForSeconds(i);
        }
    }
}

