using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevelOnAnyKey : MonoBehaviour {

    public string levelName;

	// Update is called once per frame
	void Update ()
    {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(levelName);
            }	    
	}
}
