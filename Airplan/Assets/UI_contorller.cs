using UnityEngine;
using System.Collections;

public class UI_contorller : MonoBehaviour {
    public Animator UI_BG;
    public Animator UI_button;

    public void button_click()
    {
        UI_button.SetBool("click", true);
        UI_BG.SetBool("jump", true);
    }

    public void home()
    {
        
        UI_BG.SetBool("finish", true);
    }
}
