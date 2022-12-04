using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{


    public void GoPortal()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }




}
