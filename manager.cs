using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float speed = 3;
    [SerializeField] float posValue;

    Vector2 startPos, playerPos;
    float newPosition;
    public GameObject enemy;
    float px;

    // Start is called before the first frame update
    void Start()
    {
        startPos = GameObject.Find("Background").transform.position;
        StartCoroutine(Enemy_Spawn());
        //StartCoroutine("Enemy_Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Capsule").transform.Translate(Vector3.right * -2f * Time.deltaTime);


        playerPos = GameObject.Find("Capsule").transform.position;


    }


    IEnumerator Enemy_Spawn()
    {
        px = Random.Range(15, 20);


        while (true)
        {
            GameObject g = GameObject.Instantiate(enemy, new Vector3(playerPos.x + px, -1.889193f), Quaternion.identity);
            g.AddComponent<ball>();
            g.gameObject.tag = "Enemy";
            yield return new WaitForSeconds(2);
        }
    }


}
