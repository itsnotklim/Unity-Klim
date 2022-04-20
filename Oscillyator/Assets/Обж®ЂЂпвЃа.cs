using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Осциллятор : MonoBehaviour
{
    public Vector3 pos;
    private float fi, psi, ps, t, phase, pos_x, pos_y;
    private const double G = 9.8;
    // Start is called before the first frame update
    void Start()
    {
        fi = 20;
        psi = 10;
        ps = 10;
        t = 0;
        phase = 2;
        pos = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        pos = new Vector3((float)((ps / fi) * Math.Cos(fi * t + phase)), 0, (float)((ps / psi) * Math.Sin(psi * t + phase)));
        transform.position = pos;
    }
}
