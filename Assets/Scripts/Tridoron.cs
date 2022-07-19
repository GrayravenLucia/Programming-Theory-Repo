using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tridoron : SFX// HERITAGE
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
        instance.CurrentClip = instance.tridoron;
        instance.CurrentShiftCar = "tridoron";
    }
}
