using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jowa : MonoBehaviour {
    public GameObject[] wave,rea;
    int i= 0,r=0;
    public void Newwave(float y)
    {
        if (i == 100)
        {
            y = y + 14;
            Instantiate(rea[0], new Vector2(-4, y), Quaternion.identity);
            i = 0;
        }
        else
        {
            System.Random rnd = new System.Random();
            int iR = rnd.Next(10);
            y = y + 14;
            Instantiate(wave[iR], new Vector2(-4, y), Quaternion.identity);
            i = i + 1;
        }
    }
}
