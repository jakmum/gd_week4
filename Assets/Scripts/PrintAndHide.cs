using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    private int rand;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rand = Mathf.FloorToInt(Random.Range(150.0f,251.0f));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if(gameObject.tag == "Red" && i == 100)
            gameObject.SetActive(false);
        if(gameObject.tag == "Blue" && i == rand)
            rend.enabled = false;
    }
}
