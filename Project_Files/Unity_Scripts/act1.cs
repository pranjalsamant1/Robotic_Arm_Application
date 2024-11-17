namespace RosSharp.RosBridgeClient.MessageTypes.franka_gripper
{
    [System.Serializable]
    public class FrankaGripperMoveActionGoal : Message
    {
        public ActionGoal goal;

        public FrankaGripperMoveActionGoal()
        {
            goal = new ActionGoal();
        }

        [System.Serializable]
        public class ActionGoal
        {
            public double width;
            public double speed;
        }
    }
}

