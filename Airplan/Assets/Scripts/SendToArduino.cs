using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Xml;
using System.Collections.Generic;
using System.IO;

public class SendToArduino : MonoBehaviour {
    private int baudrate = 9600;
    private string portname;
    private SerialPort sp ;

    void Awake()
    {
        //xmlpath
        string filepath = Application.dataPath + "/StreamingAssets/Data/setting.xml";
        XmlDocument xmlDoc2 = new XmlDocument();
        if (File.Exists(filepath))
        {
            Debug.Log("exist");
            xmlDoc2.Load(filepath);
            XmlNodeList portList = xmlDoc2.GetElementsByTagName("port");
            XmlNodeList boubdrateList = xmlDoc2.GetElementsByTagName("bound");
            //port
            foreach (XmlNode comportInfo in portList)
            {
                Debug.Log("INFOREACH");
                portname = comportInfo.InnerText;
                Debug.Log("PTN" + portname);
            }
            //boundrate
            foreach (XmlNode boubdrateInfo in boubdrateList)
            {
                Debug.Log("INFOREACH");
                baudrate = int.Parse(boubdrateInfo.InnerText) ;
                Debug.Log("br" + baudrate);
            }
        }
        else
        {
            Debug.Log("file not find");
        }        
    }

    // Use this for initialization
    void Start () {
        sp = new SerialPort(portname, baudrate);
        sp.Open();
        getFile.fileName = "";
        sp.Write("0");        
    }
	
	// Update is called once per frame
	void Update () {
        if (sp.IsOpen)
        {

            switch(getFile.fileName)
            {
                case "網路":
                    sp.Write("1");
                    print("1");
                    break;
                case "系統":
                    sp.Write("2");
                    print("2");
                    break;
                case "中繼":
                    sp.Write("3");
                    print("3");
                    break;
                case "偵蒐":
                    sp.Write("4");
                    print("4");
                    break;
                case "投射":
                    sp.Write("5");
                    print("5");
                    break;
                case "用途":
                    sp.Write("6");
                    print("6");
                    break;
                default:
                    break;
            }
            
        }
        
	}

    void OnApplicationQuit()
    {
        sp.Close();
        print("Close");
    }
}
