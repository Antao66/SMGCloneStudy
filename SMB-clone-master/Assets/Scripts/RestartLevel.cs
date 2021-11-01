using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour 
{
	public void RestartLevel1()
    {
        SceneManager.LoadScene("World 1-1");
       
    }
    
}
