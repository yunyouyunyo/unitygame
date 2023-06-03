using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hp;

    // Start is called before the first frame update
    void Start()
    {
        this.hp = GameObject.Find("hp");
    }

    public void Decreasehp()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void Increasehp()
    {
        this.hp.GetComponent<Image>().fillAmount += 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp.GetComponent<Image>().fillAmount == 0.0f)
        {
            SceneManager.LoadScene("clearscene");
        }
    }
}
