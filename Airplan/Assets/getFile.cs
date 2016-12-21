using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getFile : MonoBehaviour {
    public static string fileName;

    public void loadfile()
    {
        fileName = this.gameObject.name;
        print(fileName);   //Text為組件,text為內容  不用ToString();       
    }
}
