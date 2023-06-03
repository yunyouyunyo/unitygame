using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscene : MonoBehaviour
{
    public GameObject BulletPrefab;
    float span = 0.8f;
    float delta = 0;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(BulletPrefab) as GameObject;
            int px = Random.Range(-3, 3);
            go.transform.position = new Vector3(px, -3.1f, 0);
        }
    }
}
