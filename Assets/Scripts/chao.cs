using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2( - 0.5f * Time.deltaTime, 0));
        transform.Rotate(new Vector3( 0, 0, -0.5f * Time.deltaTime));
    }
}
