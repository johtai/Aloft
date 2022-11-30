using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public Canvas canv;
    void Update()
    {
      //Включение выключение панели меню
      if(Input.GetKeyDown(KeyCode.Escape))
      {
        canv.enabled = !canv.enabled;
        
      }
      
      //Эффект "Паузы" при открытии меню
      if(canv.enabled)
          Time.timeScale = 0f;
      else
        Time.timeScale = 1f;
 
    }
}
