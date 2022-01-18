using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetLevel : MonoBehaviour
{   
     string txt;
    // Start is called before the first frame update
    void Start()
    {
        int currentLevel = this.GetCurrentLevel();
        GetComponent<UnityEngine.UI.Text>().text = "LEVEL: " + currentLevel;
        
    }
    private int GetCurrentLevel() {
        int number = SceneManager.GetActiveScene().buildIndex + 1;
        return number;
    }
}
