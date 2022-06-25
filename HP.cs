using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float hp = 100;
    public Text t1, t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t1.text = "Á¡¼ö : " + hp.ToString();

        if (hp < 0.1f)
            t2.gameObject.SetActive(true);
    }
}
