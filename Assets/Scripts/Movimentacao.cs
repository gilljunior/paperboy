using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    public float velocidade = 0.5f;
    public Rigidbody2D rb;

    public GameObject rodaTraseira;
    public GameObject rodaFrontal;

    public float forcaPulo = 50f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(new Vector2(velocidade * Time.deltaTime, 0), ForceMode2D.Impulse);
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pular();
        }

        //transform.Translate(new Vector2(velocidade * Time.deltaTime, 0));
        //rb.AddForce(new Vector2(velocidade * Time.deltaTime, 0), ForceMode2D.Force);
    }
    public void pular()
    {
        rb.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
        
    }


}
