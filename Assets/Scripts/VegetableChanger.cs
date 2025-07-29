using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VegetableChanger : MonoBehaviour
{
    public Image foodImage;
    public Sprite brocoliSprite, hamburgerSprite;
    //When we hover over the food, it will become a brocoli and when
    //we uhover, it will become a hamburger

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHover()
    {
        //when we hover over the food, it will become a brocoli
        foodImage.sprite = brocoliSprite;
    }

    public void OnUnhover()
    {
        foodImage.sprite = hamburgerSprite;
    }
}
