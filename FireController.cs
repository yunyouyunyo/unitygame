using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FireController : MonoBehaviour
{
    public GameObject bulletPrefab;

    GameObject player;
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        player = GameObject.Find("cat");
        bulletPrefab = GameObject.Find("BulletPrefab");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player localScale x is ");
            Debug.Log(player.transform.localScale.x);

            Vector2 p1 = this.player.transform.position;
            Vector2 p2 = new Vector2(p1.x, p1.y + 1.0f);

            bullet = Instantiate(bulletPrefab) as GameObject;
            bullet.transform.position = p2;
        }
    }
}
