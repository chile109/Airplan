using UnityEngine;
using System;

public class wsPartMovie : MonoBehaviour
{

    Animator temp;
    public AVProWindowsMediaMovie _movieA;

    // Update is called once per frame
    void Update()
    {
                
        if (_movieA.MovieInstance.DurationSeconds  == _movieA.MovieInstance.PositionSeconds)
            {
                //播放完畢 播放離開動畫
                this.GetComponent<Animator>().SetBool("finish", true);
        }
        
    }
}
