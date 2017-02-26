using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour {

    public GameObject bong;
    public GameObject bros;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
        bong.SetActive(false);
        bros.SetActive(false);

        Invoke("ShowLogo", 8);
    }

    void ShowLogo()
    {
        bong.SetActive(true);
        bros.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
