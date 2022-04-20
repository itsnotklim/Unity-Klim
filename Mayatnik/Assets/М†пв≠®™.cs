using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Маятник : MonoBehaviour
{
    public Vector3 pos;
    public float fi, psi, sp, l;
    private float t;
    private const double g = 9.81;
    // Start is called before the first frame update
    void Start()
    {
        fi = 9;
        l = 1;
        t = 0;
        sp = 10;
        pos = new Vector3((float)(l * Math.Cos(fi)), 0, (float)(l * Math.Sin(fi)));
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        psi = (float)(fi * Math.Cos(Math.Sqrt(g / l)) * t + sp * Math.Sqrt(g / l) + fi * Math.Sin(Math.Sqrt(g / l)) * t);
        pos = new Vector3((float)(l * Math.Cos(psi)), 0, (float)(l * Math.Sin(psi)));
        transform.position = pos;
    }
}
