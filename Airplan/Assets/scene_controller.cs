using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_controller : MonoBehaviour {
    
    public void go_scene()
    {
        SceneManager.LoadSceneAsync(getFile.fileName);
    }
    public void Back()
    {        
        SceneManager.LoadSceneAsync("MENU");
    }
}
