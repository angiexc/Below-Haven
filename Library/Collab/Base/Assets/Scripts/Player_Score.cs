using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Score : MonoBehaviour {
    private float timeLeft = 5000;
    public int playerscore = 0;
    public bool level0;
    public bool level1;
    public bool levelBoos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0.1f)
        {
            if(level0 == true) {
                SceneManager.LoadScene("Charly Dang Level 0");
            } else if (level1 == true)
            {
                SceneManager.LoadScene("Charly Dang Level 1");
            } else if (levelBoss == true)
            {
                SceneManager.LoadScene("Charly Dang");
            }
            
        }
	}
}
