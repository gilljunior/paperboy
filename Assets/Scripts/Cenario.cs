﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    public float velocidade = 0.1f;
    public Rigidbody2D bike;
    public Renderer cenario;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 offset = new Vector2((bike.velocity.x *Time.deltaTime / 30), 0);
        cenario.material.mainTextureOffset += offset;

    }
}
