using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speed : SFX// HERITAGE
{

    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void UpdateSFX()// POLYMORPHISM
    {
        instance.CurrentClip = instance.speed;
        instance.CurrentShiftCar = "speed";
    }




}
