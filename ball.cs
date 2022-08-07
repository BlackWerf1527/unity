using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<CircleCollider2D>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * -2f * Time.deltaTime);
    }
}

