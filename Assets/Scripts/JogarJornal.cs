using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogarJornal : MonoBehaviour
{

    public GameObject StartPositionJornal;
    public GameObject Jornal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Executar();
        }
    }

    private void Executar()
    {
        GameObject novoJornal = Instantiate(Jornal, new Vector2(StartPositionJornal.transform.position.x, StartPositionJornal.transform.position.y) , Quaternion.identity);

    }
}
