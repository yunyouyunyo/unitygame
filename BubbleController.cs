using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    GameObject bottle;
    //控制泡泡
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.09f, 0);
        if (transform.position.y > 30)
        {
            Destroy(gameObject);
        }
    }
}
