using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottlecontroller : MonoBehaviour
{
    GameObject player;
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;

        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().Decreasehp();

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gameObject.tag + " entered trigger tagged " + other.gameObject.tag);
        if (other.gameObject.tag == "bullet")
        {
            Debug.Log(other.gameObject.tag);
            Destroy(gameObject);
            Vector2 p1 = transform.position;
            Vector2 p4 = other.gameObject.transform.position;
            Vector2 dir3 = p1 - p4;
            float d3 = dir3.magnitude;
            if (d3 < 2.0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
