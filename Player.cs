using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool RunAv = true, sndJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * 5 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("MainCamera").transform.Translate(Vector3.right * 1.5f * Time.deltaTime);
            //GameObject.Find("Background").transform.Translate(Vector3.right * 0.3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.right * -5 * Time.deltaTime);
            GameObject.FindGameObjectWithTag("MainCamera").transform.Translate(Vector3.right * -1.5f * Time.deltaTime);
            //GameObject.Find("Background").transform.Translate(Vector3.right * -0.3f * Time.deltaTime);
        }
       
        if (Input.GetKeyDown(KeyCode.UpArrow) && RunAv)
        {
            RunAv = false;
            //this.transform.Translate(Vector3.up * 1);
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 5, ForceMode2D.Impulse);
        }
        if (!RunAv && !sndJump && Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 7, ForceMode2D.Impulse);
            sndJump = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //this.transform.localScale -= new Vector3(0, 0.2f, 0);
            this.transform.localScale = new Vector3(1, 0.8f, 1);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.transform.localScale += new Vector3(0, 0.2f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            RunAv = true;
            sndJump = false;
        }

        //if (collision.gameObject.tag == "Enemy")
        //    GameObject.Find("Canvas").GetComponent<HP>().hp -= 10;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            GameObject.Find("Canvas").GetComponent<HP>().hp -= 10;
    }
}
