using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float Vel = 0.1f;
    public Renderer quad; 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Vel * Time.deltaTime, 0);

        quad.material.mainTextureOffset += offset;
    }
}