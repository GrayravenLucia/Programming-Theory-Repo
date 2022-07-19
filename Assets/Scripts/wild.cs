using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wild : SFX// HERITAGE
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
        instance.CurrentClip = instance.wild;
        instance.CurrentShiftCar = "wild";
    }
}
