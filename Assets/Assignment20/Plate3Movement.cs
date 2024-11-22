using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate3Movement : MonoBehaviour
{
    float x = 0.5f;
    float y = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position += new Vector3(x, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-x, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, y, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -y, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position = Vector3.zero;
        }
    }
}
