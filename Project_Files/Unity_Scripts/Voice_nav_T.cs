///////////////////////////////////////////////////////////////////////////////
//
// RealWear Development Software, Source Code and Object Code
// (c) RealWear, Inc. All rights reserved.
//
// Contact info@realwear.com for further information about the use of this
// code.
//
///////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.SceneManagement;
using WearHFPlugin;
using System.Collections;

/// <summary>
/// Demonstrates how to add custom commands on the HMT
/// </summary>
public class AddCommands6 : Nav_Robot_Control
{
    /// <summary>
    /// The WearHF object
    /// </summary>
    private WearHF m_wearHF;

    /// <summary>
    /// See Unity docs
    /// </summary>
    void Start()
    {
        // Initialize the wearHF object
        // NOTE: The plugin registers itself to the WearHF system in the
        // GameObjects Awake function, so any calls to the plugin need to occur
        // after that. The start function is a good choice.
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();

        // Add custom commands 
        m_wearHF.AddVoiceCommand("Go Back", Nav_RC);

        // Clean up when we're finished.

        SceneManager.sceneUnloaded += SceneUnloaded;


    }

    /// <summary>
    /// Called when our custom commands are spoken.
    /// </summary>
    /// <param name="voiceCommand">The voice command that was recognized.</param>
    private void Nav_RC(string voiceCommand)
    {
        SceneManager.LoadScene("App_Main_Screen");
    }

    /// <summary>
    /// Called when the scene is unloaded.
    /// Used to clean up WearHF.
    /// </summary>
    /// <param name="scene">The unloaded scene.</param>
    private void SceneUnloaded(Scene scene)
    {
        m_wearHF.EnableGlobalCommands = true;
        m_wearHF.ClearCommands();
    }
}
