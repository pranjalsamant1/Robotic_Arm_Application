using UnityEngine;
using UnityEngine.UI;
using WearHFPlugin;
using System;
public class AddCommands4 : Nav_Robot_Control
{
    private WearHF m_wearHF;
    public Button[] buttonsToClick;
    void Start()
    {
        m_wearHF = GameObject.Find("WearHF Manager").GetComponent<WearHF>();
        // custom commands for each buttons
        m_wearHF.AddVoiceCommand("Move up", OnMoveUp);
        m_wearHF.AddVoiceCommand("Move down", OnMoveDown);
        m_wearHF.AddVoiceCommand("Move left", OnMoveLeft);
        m_wearHF.AddVoiceCommand("Move right", OnMoveRight);
        m_wearHF.AddVoiceCommand("Move forward", OnMoveForward);
        m_wearHF.AddVoiceCommand("Move backward", OnMoveBackward);
        m_wearHF.AddVoiceCommand("Robot stop", OnRobotStop);
        m_wearHF.AddVoiceCommand("Robot reset", OnRobotReset);
        m_wearHF.AddVoiceCommand("Speed high", OnSpeedHigh);
        m_wearHF.AddVoiceCommand("Speed medium", OnSpeedMedium);
        m_wearHF.AddVoiceCommand("Speed slow", OnSpeedSlow);
    }
    // methods to handle each voice command
    private void OnMoveUp(string command) { OnButtonClicked("Move up"); }
    private void OnMoveDown(string command) { OnButtonClicked("Move down"); }
    private void OnMoveLeft(string command) { OnButtonClicked("Move left"); }
    private void OnMoveRight(string command) { OnButtonClicked("Move right"); }
    private void OnMoveForward(string command) { OnButtonClicked("Move forward"); }
    private void OnMoveBackward(string command) { OnButtonClicked("Move backward"); }
    private void OnRobotStop(string command) { OnButtonClicked("Robot stop"); }
    private void OnRobotReset(string command) { OnButtonClicked("Robot reset"); }
    private void OnSpeedHigh(string command) { OnButtonClicked("Speed high"); }
    private void OnSpeedMedium(string command) { OnButtonClicked("Speed medium"); }
    private void OnSpeedSlow(string command) { OnButtonClicked("Speed slow"); }
    private void OnButtonClicked(string command)
    {
    	Debug.Log("Voice Command Recieved: " + command + " at " + GetTimestamp());
        switch (command)
        {
            case "Move up":
            case "Move down":
            case "Move left":
            case "Move right":
            case "Move forward":
            case "Move backward":
            case "Robot stop":
            case "Robot reset":
            case "Speed high":
            case "Speed medium":
            case "Speed slow":
                int buttonIndex = GetButtonIndex(command);
                if (buttonIndex != -1)
                {
                    buttonsToClick[buttonIndex].onClick.Invoke();
                }
                break;
            default:
                Debug.LogError("Unknown command: " + command);
                break;
        }
    }
    private int GetButtonIndex(string command)
    {
        switch (command)
        {
            case "Move up": return 0;
            case "Move down": return 1;
            case "Move left": return 2;
            case "Move right": return 3;
            case "Move forward": return 4;
            case "Move backward": return 5;
            case "Robot stop": return 6;
            case "Robot reset": return 7;
            case "Speed high": return 8;
            case "Speed medium": return 9;
            case "Speed slow": return 10;
            default: return -1;
        }
    }
    private string GetTimestamp()
    {
    	return DateTime.Now.ToString("HH:mm:ss.fff");
    }
    
}

