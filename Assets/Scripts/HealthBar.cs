using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{
    //[SerializeField] private player _player;
    private Slider _slider;


    private void Start() 
    {
        _slider = GetComponent<Slider>();
    }

    private void Update() 
    {
        //_slider.value = _player.health;
    }



}
