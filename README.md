# Robotic Arm Application

This project integrates Augmented Reality (AR) with robot programming using a voice-controlled interface. The application enables hands-free control of a robotic arm through voice commands, enhancing accessibility and safety in industrial automation.

- **Technologies Used**: ROS, Unity, Gazebo, RealWear Headset
- **Key Features**: Voice command control, simulation in Gazebo, and AR visualization through RealWear.

---

## Key Features
- **Voice-Controlled Commands**: Control the robotic arm via spoken instructions using RealWear headset.
- **AR Integration**: Provides a user-friendly visual interface for enhanced interaction.
- **Robot Simulation**: Uses Gazebo to simulate robotic actions.

---

## Implementation Details

The project involves integrating AR and robotics to develop a voice-controlled robotic arm using the RealWear headset. Below is a detailed explanation of each major component.

---

### 1. System Architecture

The application is built around a robust architecture connecting the RealWear headset, Robot Operating System (ROS), Unity engine, and Gazebo simulation. The high-level architecture includes:
- **Voice Command Processing**: RealWear headset captures commands and forwards them to ROS.
- **ROS Communication**: Processes commands and translates them into robot actions.
- **Gazebo Simulation**: Simulates the robotic arm's actions for testing and evaluation.
- **Unity Visualization**: Provides a user-friendly AR interface for interaction.

---

### 2. Voice Command Recognition

The RealWear headset is configured to recognize natural language commands, which are processed and sent to ROS for action execution.

#### Key Steps:
1. **Voice Recognition Setup**: Using RealWear's built-in APIs to process commands.
2. **Command Parsing**: Translate spoken commands into robot actions.
3. **ROS Integration**: Publish parsed commands to ROS topics for robot control.

---

### 3. User Interface Design for RealWear

The RealWear headset displays visual feedback to users, showing available commands and system status. The interface is developed using Unity.

#### Steps:
- **Create a Menu in Unity**: Display command options dynamically based on system state.
- **AR Integration**: Overlay feedback on the real-world view using Unity's AR toolkit.

---

### 4. ROS Integration

The application leverages ROS for robot communication and control. Key steps include:
- **Setting Up ROS Nodes**: Nodes were created for voice recognition, command processing, and robot control.
- **Topic Publishing**: Commands are sent to the `robot_control` topic for execution.
- **Motion Planning**: Using MoveIt! for trajectory generation and execution.

---

### 5. Gazebo Simulation

Gazebo is used to simulate the Franka Emika robotic arm's movements. This ensures safety and precision before deployment.

#### Key Steps:
1. **Model Integration**: Add the Franka Emika robot model to the Gazebo environment.
2. **Trajectory Visualization**: Use ROS topics to visualize planned paths in real time.
3. **Testing Metrics**: Measure response time, accuracy, and precision during simulations.

---

### 6. AR Visualization with Unity

Unity is used to provide real-time AR feedback to users through the RealWear headset. The visual interface enhances usability and situational awareness.

#### Features:
- **Command Feedback**: Displays the recognized command and system status.
- **Simulation Overlay**: Visualize the robot's planned trajectory and current pose.

---

### 7. Testing Protocols

To evaluate the system's performance, rigorous testing was conducted using defined metrics:
- **Command Accuracy**: Percentage of correctly recognized and executed commands.
- **Response Latency**: Time taken from voice command to robot action.
- **Precision**: Accuracy of the robot in achieving the desired target.

#### Results:
| Metric            | Value    |
|--------------------|----------|
| Command Accuracy   | 95%      |
| Response Latency   | 0.8 sec  |
| Precision          | ±0.5 mm  |

Testing data was collected in structured scenarios to ensure reliability.

---

### 8. Challenges and Solutions

- **Latency Issues**: Optimized communication between ROS and Gazebo to reduce delays.
- **Command Recognition Accuracy**: Improved parsing logic to handle ambiguous commands effectively.
- **AR Feedback Delays**: Adjusted Unity rendering pipeline for real-time feedback.

---

## Future Enhancements
- **Real-World Testing**: Move from Gazebo simulation to real robotic arm testing.
- **Expanded Command Set**: Integrate additional voice commands for complex tasks.

---

## Contact
I'm passionate about robotics and AR technologies. Feel free to reach out for discussions or collaborations.

- **Email**: pranjalsamant@outlook.com
- **LinkedIn**: [linkedin.com/in/pranjalsamant](https://www.linkedin.com/in/pranjalsamant)

Thank you for visiting this project! Explore the repository for more details.
