using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpforce = 680.0f;
    float walkforce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;
    GameObject director;
    GameObject verb;

    int verb_eat = 00;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        director = GameObject.Find("GameDirector");
        verb = GameObject.Find("verb");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpforce);
        }

        int key = 0;
        if (Input.acceleration.x > this.threshold)
            key = 1;
        if (Input.acceleration.x < -this.threshold)
            key = -1;
        if (Input.GetKey(KeyCode.RightArrow))
            key = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkforce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("clearscene");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("終點");

        Debug.Log(gameObject.tag + " entered trigger tagged " + other.gameObject.tag);
        if (other.gameObject.tag == "green")
        {
            Debug.Log(other.gameObject.tag);
            Destroy(other.gameObject);
            director.GetComponent<GameDirector>().Increasehp();

            verb_eat += 01;
            this.verb.GetComponent<Text>().text = "Verb : " + verb_eat.ToString("D2");
        }
        if (other.gameObject.name == "flag")
        {
            Debug.Log("Finish !");
            SceneManager.LoadScene("endscean");
        }
    }
}
