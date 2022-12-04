using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalBack : MonoBehaviour
{
    public Transform Player;

    public void GoPortal()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //Player.position = new Vector3(-58, 15, 0);

    }

}
