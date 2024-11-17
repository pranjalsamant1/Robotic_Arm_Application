using UnityEngine;
using UnityEngine.UI;
using RosSharp.RosBridgeClient;
using std_msgs = RosSharp.RosBridgeClient.MessageTypes.Std;

namespace YourNamespace
{
    public class HelloPublisher : UnityPublisher<std_msgs.String>
    {
        public Button[] buttons;

        void Awake()
        {
            Topic = "/cmd";
            for (int i = 0; i < buttons.Length; i++)
            {
                int buttonIndex = i; 
                buttons[i].onClick.AddListener(() => PublishMessage(buttonIndex));
            }
        }
        void PublishMessage(int buttonIndex)
        {
            string messageData = GetMessageData(buttonIndex);
            std_msgs.String message = new std_msgs.String
            {
                data = messageData
            };
            Publish(message);
        }
        string GetMessageData(int buttonIndex)
        {
            switch (buttonIndex)
            {
                case 0: return "move_right";
                case 1: return "move_left";
                case 2: return "move_forward";
                case 3: return "move_backward";
                case 4: return "move_up";
                case 5: return "move_down";
                case 6: return "reset";
                case 7: return "stop";
                case 8: return "high";
                case 9: return "medium";
                case 10: return "slow";
                case 11: return "pick";
                case 12: return "place";
                default: return ""; // Invalid button index
            }
        }
    }
}
