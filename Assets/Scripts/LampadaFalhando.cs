using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampadaFalhando : MonoBehaviour
{
    public Light luz;
    public GameObject emissiveObject;
    //public AudioSource audioSource;
    public AnimationCurve animationCurve;

    public WrapMode wrapmode = WrapMode.PingPong;

    void Start(){
        this.animationCurve.postWrapMode = this.wrapmode;
    }   

    // Update is called once per frame
    void Update()
    {
        float value  = animationCurve.Evaluate(Time.time);

        this.luz.intensity = value;

       /* if(value >= 0.9 && !this.audioSource.isPlaying){
            this.audioSource.Play();
        }*/
        
    }
}
