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
    class HandListener : Listener
    {
        Form1.SymbolReceiver symbolCallback;
        AslClassifier classifier = new AslClassifier();

        public HandListener(Form1.SymbolReceiver symbol_callback)
        {
            symbolCallback = symbol_callback;
        }

        public override void OnInit(Controller controller)
        {
            Console.WriteLine("Initialized");
        }

        public override void OnConnect(Controller controller)
        {
            Console.WriteLine("Connected");
        }

        public override void OnDisconnect(Controller controller)
        {
            //Note: not dispatched when running in a debugger.
            Console.WriteLine("Disconnected");
        }

        public override void OnExit(Controller controller)
        {
            Console.WriteLine("Exited");
        }

        public override void OnFrame(Controller controller)
        {
            // Get the most recent frame and report some basic information
            Frame frame = controller.Frame();

            string line = "";

            foreach (Hand hand in frame.Hands)
            {
                //Console.WriteLine("  Hand id: " + hand.Id
                //            + ", palm position: " + hand.PalmPosition);
                // Get the hand's normal vector and direction
                Vector normal = hand.PalmNormal;
                Vector direction = hand.Direction;

                // Calculate the hand's pitch, roll, and yaw angles
                line += normal.Roll + " " + direction.Yaw;

                // Get the Arm bone
                Arm arm = hand.Arm;

                // Get fingers
                foreach (Finger finger in hand.Fingers)
                {

                    // Get finger bones
                    Bone bone;
                    foreach (Bone.BoneType boneType in (Bone.BoneType[])Enum.GetValues(typeof(Bone.BoneType)))
                    {
                        bone = finger.Bone(boneType);
                        Vector prev = bone.PrevJoint - arm.WristPosition;
                        Vector next = bone.NextJoint - arm.WristPosition;
                        line += " " + prev.x + " " + prev.y + " " + prev.z
                            + " " + next.x + " " + next.y + " " + next.z
                            + " " + bone.Direction.x + " " + bone.Direction.y + " " + bone.Direction.z;
                    }
                }

            }
            
        }
    }
}