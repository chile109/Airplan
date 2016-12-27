using UnityEngine;
using System.Collections;

public class UI_contorller : MonoBehaviour {
    public Animator UI_BG;
    public Animator UI_button;

    public void button_click()
    {
        //按下MENU按鈕，跳轉到影片
        UI_button.SetBool("click", true);
        UI_BG.SetBool("jump", true);
    }

    public void home()
    {
        //按下X回到MENU
        UI_BG.SetBool("finish", true);
    }
}
