using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodaTraseira : MonoBehaviour
{

    public WheelJoint2D whelJoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            whelJoint.useMotor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            whelJoint.useMotor = false;
        }
    }
}
