

using UnityEngine;
using UnityEngine.SceneManagement;
using WearHFPlugin;
using System.Collections;

public class AddCommands : Nav_Robot_Control
{

    private WearHF m_wearHF;

    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();
        //custom commands 
        m_wearHF.AddVoiceCommand("Robot Control", Nav_RC);
        SceneManager.sceneUnloaded += SceneUnloaded;
    }

    private void Nav_RC(string voiceCommand)
    {
        SceneManager.LoadScene("Robot_Control_Scene");
    }

    private void SceneUnloaded(Scene scene)
    {
        m_wearHF.EnableGlobalCommands = true;
        m_wearHF.ClearCommands();
    }
}
