using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Jornal : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce( new Vector2( velocidade , velocidade));
        rb.AddTorque(-50f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
                Destroy(gameObject);
         
        }
    }
}
