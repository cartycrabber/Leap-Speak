/******************************************************************************\
* Copyright (C) 2012-2014 Leap Motion, Inc. All rights reserved.               *
* Leap Motion proprietary and confidential. Not for distribution.              *
* Use subject to the terms of the Leap Motion SDK Agreement available at       *
* https://developer.leapmotion.com/sdk_agreement, or another agreement         *
* between Leap Motion and you, your company or other organization.             *
\******************************************************************************/
using System;
using System.Threading;
using Leap;
using System.IO;
using System.Collections.Generic;

namespace TeachAslCsharp
{
    class DataGathererListener : Listener
    {
        private Object thisLock = new Object();

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnInit(Controller controller)
        {
            records = new List<string>();
            SafeWriteLine("Initialized");
        }

        public override void OnConnect(Controller controller)
        {
            SafeWriteLine("Connected");
            /*controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPE_KEY_TAP);
            controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);
            controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);*/
        }

        public override void OnDisconnect(Controller controller)
        {
            //Note: not dispatched when running in a debugger.
            SafeWriteLine("Disconnected");
        }

        public override void OnExit(Controller controller)
        {
            SafeWriteLine("Exited");
        }

        public List<string> records;
        public bool record = false;
        public string label = "";
        public int maxRecords = -1;

        public override void OnFrame(Controller controller)
        {
            if (!record)
                return;
            if (maxRecords > 0 && maxRecords < records.Count)
            {
                record = false;
                Console.WriteLine("Record target reached. Enter stop command to exit recording session");
            }
            // Get the most recent frame and report some basic information
            Frame frame = controller.Frame();

            //SafeWriteLine("Frame id: " + frame.Id
            //            + ", timestamp: " + frame.Timestamp
            //            + ", hands: " + frame.Hands.Count
            //            + ", fingers: " + frame.Fingers.Count
            //            + ", tools: " + frame.Tools.Count
            //            + ", gestures: " + frame.Gestures().Count);

            string line = "";

            foreach (Hand hand in frame.Hands)
            {
                //SafeWriteLine("  Hand id: " + hand.Id
                //            + ", palm position: " + hand.PalmPosition);
                // Get the hand's normal vector and direction
                Vector normal = hand.PalmNormal;
                Vector direction = hand.Direction;

                // Calculate the hand's pitch, roll, and yaw angles
                //SafeWriteLine("  Hand pitch: " + direction.Pitch * 180.0f / (float)Math.PI + " degrees, "
                //            + "roll: " + normal.Roll * 180.0f / (float)Math.PI + " degrees, "
                //            + "yaw: " + direction.Yaw * 180.0f / (float)Math.PI + " degrees");
                line += label + " " + normal.Roll + " " + direction.Yaw;

                // Get the Arm bone
                Arm arm = hand.Arm;
                //SafeWriteLine("  Arm direction: " + arm.Direction
                //            + ", wrist position: " + arm.WristPosition
                //            + ", elbow position: " + arm.ElbowPosition);
                line += " " + arm.Direction.x + " " + arm.Direction.y + " " + arm.Direction.z
                    + " " + arm.WristPosition.x + " " + arm.WristPosition.y + " " + arm.WristPosition.z;

                // Get fingers
                foreach (Finger finger in hand.Fingers)
                {
                    //SafeWriteLine("    Finger id: " + finger.Id
                    //            + ", " + finger.Type.ToString()
                    //            + ", length: " + finger.Length
                    //            + "mm, width: " + finger.Width + "mm");

                    // Get finger bones
                    Bone bone;
                    foreach (Bone.BoneType boneType in (Bone.BoneType[])Enum.GetValues(typeof(Bone.BoneType)))
                    {
                        bone = finger.Bone(boneType);
                        //SafeWriteLine("      Bone: " + boneType
                        //            + ", start: " + bone.PrevJoint
                        //            + ", end: " + bone.NextJoint
                        //            + ", direction: " + bone.Direction);
                        line += " " + bone.PrevJoint.x + " " + bone.PrevJoint.y + " " + bone.PrevJoint.z
                            + " " + bone.NextJoint.x + " " + bone.NextJoint.y + " " + bone.NextJoint.z
                            + " " + bone.Direction.x + " " + bone.Direction.y + " " + bone.Direction.z;
                    }
                }

            }
            //Console.WriteLine("Data points: " + line.Split(" ").Length);
            if (line.Length > 5)
                records.Add(line);

            if (records.Count % 100 == 0)
            {
                Console.WriteLine(records.Count + " records");
            }
        }
    }

    class DataGatherer
    {
        public static void Main()
        {
            // Create a sample listener and controller
            DataGathererListener listener = new DataGathererListener();
            Controller controller = new Controller();

            // Have the sample listener receive events from the controller
            controller.AddListener(listener);

            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "start":
                        Console.WriteLine("Recording");
                        listener.record = true;
                        break;
                    case "s":
                        Console.WriteLine("Stopping");
                        listener.record = false;
                        Console.WriteLine("Processed " + listener.records.Count + " lines");
                        break;
                    case "quit":
                        Console.WriteLine("Quitting");
                        run = false;
                        break;
                    case "write":
                        Console.WriteLine("Writing to file");
                        using (StreamWriter samplesFileStream = File.AppendText("samples.txt"))
                        {
                            foreach (string line in listener.records)
                                samplesFileStream.WriteLine(line);
                        }
                        Console.WriteLine("Done writing to file");
                        break;
                    case "clear":
                        Console.WriteLine("Clearing unsaved records");
                        listener.records.Clear();
                        break;
                    default:
                        Console.WriteLine("Defaulting");
                        string[] words = input.Split(" ");
                        if (words.Length == 2)
                        {
                            if (words[0].Equals("set"))
                            {
                                listener.label = words[1];
                                Console.WriteLine("Set label to " + listener.label);
                            }
                            else if (words[0].Equals("target"))
                            {
                                try
                                {
                                    listener.maxRecords = int.Parse(words[1]);
                                    Console.WriteLine("Set target records to " + listener.maxRecords);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Enter an integer dummy");
                                }
                            }
                        }
                        break;
                }
            }

            // Remove the sample listener when done
            controller.RemoveListener(listener);
            controller.Dispose();
        }
    }
}