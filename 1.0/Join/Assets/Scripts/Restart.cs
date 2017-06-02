using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public Button restart;

	// Use this for initialization
	void Start () {
        Button restartButton = restart.GetComponent<Button>();
        restartButton.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            TaskOnClick();

        }

	}

    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
