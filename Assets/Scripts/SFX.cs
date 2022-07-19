using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public static SFX instance;

    [SerializeField] private string currentShiftCar;
    private AudioClip currentClip;
    public AudioClip fire;
    public AudioClip drive;
    public AudioClip speed;
    public AudioClip speed_standby;
    public AudioClip wild;
    public AudioClip wild_standby;
    public AudioClip formula;
    public AudioClip formula_standby;
    public AudioClip tridoron;
    public AudioClip tridoron_standby;
    public AudioSource audioSource;
    protected bool played = false;
    protected bool shiftCarLoaded;


    // ENCAPSULATION
    public string CurrentShiftCar { get => currentShiftCar; set => currentShiftCar = value; }
    public AudioClip CurrentClip { get => currentClip; set => currentClip = value; }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CurrentShiftCar = "fire";
        currentClip = fire;
        audioSource.clip = fire;
    }
    private void Awake()
    {
    
        instance = this;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        afterSFX();// ABSTRACTION

    }
    public virtual void PlaySFX()
    {

        audioSource.Stop();
        audioSource.PlayOneShot(currentClip);
        played = true;
        
    }

    public void afterSFX()// ABSTRACTION
    {
        if (played)
        {
            
            switch (currentShiftCar)
            {
                case "fire":
                    if (!audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(drive);
                        played = false;
                    }
                    break;
                default:
                    shiftCarLoaded = true;
                    played = false;
                    break;
                    

            }
            

            
        }
        

    }

    public virtual void UpdateSFX()// POLYMORPHISM
    {
        if (shiftCarLoaded)
        {
            switch (currentShiftCar)
            {
                case "speed":
                    currentClip = speed_standby;
                    played = false;
                    break;
                case "wild":
                    currentClip = wild_standby;
                    played = false;
                    break;
                case "formula":
                    currentClip = formula_standby;
                    played = false;
                    break;
                case "tridoron":
                    currentClip = tridoron_standby;
                    played = false;
                    break;
            }
        }
    }
    public void Unload()
    {
        CurrentShiftCar = "fire";
        currentClip = fire;
        audioSource.clip = fire;
        audioSource.Stop();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
