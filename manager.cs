using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Capsule").transform.Translate(Vector3.right * -2f * Time.deltaTime);
    }
}
