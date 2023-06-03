using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.09f, 0);

        if (transform.position.y > 30.0f)
        {
            Destroy(gameObject);
        }
    }
}
