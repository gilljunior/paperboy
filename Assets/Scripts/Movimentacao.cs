using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    public float velocidade = 1000f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(new Vector2(velocidade * Time.deltaTime, 0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector2(velocidade * Time.deltaTime, 0));
        //rb.AddForce(new Vector2(velocidade * Time.deltaTime, 0), ForceMode2D.Force);
    }


}
