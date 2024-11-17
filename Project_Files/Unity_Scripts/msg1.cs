namespace RosSharp.RosBridgeClient.MessageTypes.franka_gripper
{
    [System.Serializable]
    public class GraspEpsilon : Message
    {
        public double inner;
        public double outer;
    }
}

