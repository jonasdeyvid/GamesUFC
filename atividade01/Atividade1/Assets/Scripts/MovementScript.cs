using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.gameObject.transform.Translate(Vector3.left*0.1f);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            this.gameObject.transform.Translate(Vector3.right*0.1f);
        }

         if (Input.GetKey(KeyCode.UpArrow)) {
            this.gameObject.transform.Translate(Vector3.forward*0.1f);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            this.gameObject.transform.Translate(Vector3.forward*-0.1f);
        }

    }
}
