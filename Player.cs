using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool RunAv = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * 5 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.right * -5 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && RunAv)
        {
            RunAv = false;
            //this.transform.Translate(Vector3.up * 1);
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 10, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            RunAv = true;

        //if (collision.gameObject.tag == "Enemy")
        //    GameObject.Find("Canvas").GetComponent<HP>().hp -= 10;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            GameObject.Find("Canvas").GetComponent<HP>().hp -= 10;
    }
}
