using UnityEngine;
using System;

public class wsPartMovie : MonoBehaviour
{

    Animator temp;
    public AVProWindowsMediaMovie _movieA;



    // Use this for initialization
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
                
        if (_movieA.MovieInstance.DurationSeconds  == _movieA.MovieInstance.PositionSeconds)
            {
                print("PlayCompleted,Client1;");     //播放完畢 回傳SERVER
                this.GetComponent<Animator>().SetBool("finish", true);
        }
        
    }
}
