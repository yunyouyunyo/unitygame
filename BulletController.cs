using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float Bullet_speed = 5.0f;
    float span = 1.0f;
    float delta = 0;
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    public void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
        }
        if (this.gameObject.transform.localScale.y == 0.1f)
        {
            this.gameObject.transform.Translate(0, Bullet_speed * Time.deltaTime * 1, 0);
        }

        if ((transform.position.y >= 15) || (transform.position.y <= -15))
        {
            Destroy(gameObject);
        }
    }
}
