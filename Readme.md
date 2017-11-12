# Teach ASL
We use motion tracking to translate and teach American Sign Language, bridging the gap between the deaf and hearing.

## Inspiration
We originally started by just reserving the two pieces of hardware available that seemed the coolest: the Oculus Rift and something we had never heard of before, the Leap Motion.  After not too long, we realized that the Leap Motion was far more unique and held more potential than just VR integration.  We decided to tackle the vaguest and most difficult challenge presented to us: bringing people close together.

## What it does
Teach ASL both translates sign-language hand motions into english and helps you learn basic english words in ASL.  The simple interface has two panels: one that pages through instructions on how to make the signs and another that allows you to test your skills.

## How I built it
The project is build using C# on .NET 4.0 using the Accord Machine Learning library and the Leap Motion V2 SDK.  Many man hours went into collecting a dataset and training the AI.

## Challenges I ran into
Initially we tried to build the project using C++ and CMake for the possibility of having code that could run on both Windows and Linux.  We soon realized that the pains of getting this to work would take too much time and running on Linux wasn't essential to our final goal.

## Accomplishments that I'm proud of
The core of our project is build off of our custom machine learning code.  We created our own huge dataset (too large to fit in GitHub without LFS) and trained our own ML classifiers to identify the different signs we support.

## What I learned
Never underestimate the value of quick and dirty.  Origininally, we were hoping to get a visualization of the user's hands in our application so that they could see what the computer saw.  As it approached midnight however, we realized this was an extra feature and we needed to invest more time into our core features.

## What's next for teach-asl-csharp
There's so much going on right now with 3D motion tracking that it's hard to imagine what we couldn't do with this project.  It's plausible that we could port the code to work with the Kinect, or even the iPhone X!  Imagine being able to use our project as an app for learning a foreign language, except instead of French or Mandarin we're teaching sign.

## Building

This project is build using Visual Studios 2017, NuGet, and the Leap Motion V2 SDK.  It only builds on Windows amd64.
