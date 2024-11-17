using UnityEngine;
using UnityEngine.UI;
using RosSharp.RosBridgeClient;
using std_msgs = RosSharp.RosBridgeClient.MessageTypes.Std;

namespace YourNamespace1
{
    public class HelloPublisher : UnityPublisher<std_msgs.String>
    {
        public Button buttonPick; // Reference to the Pick button in the Unity Editor
        public Button buttonPlace; // Reference to the Place button in the Unity Editor

        void Awake()
        {
            // Ensure the topic is set to "/hello"
            Topic = "/hello";

            // Add event listeners to the buttons
            buttonPick.onClick.AddListener(PublishPick);
            buttonPlace.onClick.AddListener(PublishPlace);
        }

        // Method to publish "pick" message
        void PublishPick()
        {
            // Create a new std_msgs.String message with the text "pick"
            std_msgs.String message = new std_msgs.String
            {
                data = "pick"
            };

            // Publish the message
            Publish(message);
        }
        
        // Method to publish "place" message
        void PublishPlace()
        {
            // Create a new std_msgs.String message with the text "place"
            std_msgs.String message = new std_msgs.String
            {
                data = "place"
            };

            // Publish the message
            Publish(message);
        }
    }
}

