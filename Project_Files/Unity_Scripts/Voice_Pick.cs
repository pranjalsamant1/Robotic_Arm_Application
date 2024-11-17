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
using UnityEngine.UI;
using WearHFPlugin;

/// <summary>
/// Demonstrates how to add custom commands on the HMT
/// </summary>
public class AddCommands3 : Nav_Robot_Control
{
    /// <summary>
    /// The WearHF object
    /// </summary>
    private WearHF m_wearHF;

    /// <summary>
    /// The button to be clicked when "Robot pick" command is recognized
    /// </summary>
    public Button buttonToClick;

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

        // Add custom command 
        m_wearHF.AddVoiceCommand("Robot place", OnRobotPick);
    }

    /// <summary>
    /// Called when "Robot pick" command is recognized.
    /// </summary>
    /// <param name="voiceCommand">The voice command that was recognized.</param>
    private void OnRobotPick(string voiceCommand)
    {
        // Click the button when "Robot pick" command is recognized
        buttonToClick.onClick.Invoke();
    }
}

