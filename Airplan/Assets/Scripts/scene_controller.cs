using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_controller : MonoBehaviour {
    
    public void go_scene()
    {
        //跳轉Movie,for Animator 
        SceneManager.LoadSceneAsync(getFile.fileName);
    }
    public void Back()
    {   
        //返回MENU,for Animator     
        SceneManager.LoadSceneAsync("MENU");
    }
}
