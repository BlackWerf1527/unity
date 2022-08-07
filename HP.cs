using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public float hp = 100, coin = 15, get_coin;
    public Text t1, t2, t3;
    public bool armor = false;
    int[] barrier = new int[5];
    public GameObject g;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t1.text = "체력 : " + hp.ToString();

        if (hp < 0.1f)
        {
            t2.gameObject.SetActive(true);
            t3.text = "먹은 코인의 개수 : " + get_coin.ToString();
            Time.timeScale = 0;
        }
    }


    public void b1()
    {
        if (coin >= 5)
        {
            coin -= 5;
            hp = 100;
        }
        else
            Debug.Log("코인 부족");
    }
    public void b2()
    {
        if (coin >= 5 && !armor)
        {
            coin -= 5;
            armor = true;
        }
        else if (armor)
           Debug.Log("아머가 이미 있음") ;
        else
            Debug.Log("코인 부족");
    }
    public void back()
    {
        GameObject.Find("Store").SetActive(false);
        GameObject.Find("Canvas").transform.Find("button").gameObject.SetActive(true);
    }



    public void Game_Start()
    {
        g.SetActive(true);
        GameObject.Find("button").SetActive(false);
        GameObject.Find("Canvas").transform.Find("Score").gameObject.SetActive(true);

        Time.timeScale = 1;
    }
    public void Store()
    {
        GameObject.Find("Canvas").transform.Find("Store").gameObject.SetActive(true);
        GameObject.Find("button").SetActive(false);

    }
    public void Quit()
    {
        Application.Quit();
    }
}
