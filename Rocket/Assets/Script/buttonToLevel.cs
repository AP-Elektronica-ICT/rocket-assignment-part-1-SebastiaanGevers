using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonToLevel : MonoBehaviour
{
    public string mLevelTOLoad;

    public void LoadLevel(){
        // load new level
        SceneManager.LoadScene(mLevelTOLoad);
    }
}
