using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject P1;

    [SerializeField]
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        //P1 = GameObject.Find("Player");
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            P1.transform.Translate(new Vector3(4f, 0, 0) * Time.deltaTime);
            Debug.Log("Go Right\n");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            P1.transform.Translate(new Vector3(-4f, 0, 0) * Time.deltaTime);
            Debug.Log("Go left\n");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && P1.GetComponent<Rigidbody2D>().velocity.y == 0f)
        {
            //P1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 50f, 0f));
            rigid.AddForce(new Vector3(0f, 350f, 0f));
            Debug.Log("Jump\n");
        }
    }
}