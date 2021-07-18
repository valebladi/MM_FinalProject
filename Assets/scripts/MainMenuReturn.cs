using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReturn : MonoBehaviour
{
    public void TaskOnClick(){
		SceneManager.LoadScene("MainMenu");
        print("-----------");
	}

}
