using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryTrigger : MonoBehaviour
{
    public Animator anim;

        void Update()
        {
        
            if(Input.GetKeyDown(KeyCode.Q))
            {
                anim.SetTrigger("isTrigger");
            }

        }

}
