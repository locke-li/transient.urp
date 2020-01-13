# unity_urp_modified
modified duplicate of Unity URP 7.1.7

+ resume support for CameraClearFlags.DepthOnly.
+ option to grab rendered texture after transparent rendering.
+ per camera render scale (with ~2.5% error \*1)

[Unity Companion License](https://unity3d.com/legal/licenses/Unity_Companion_License)

*\*1 Implemented through blit with blending. Due to 1. gamma blending 2. premultipled alpha, an ~2.5% error is accumulated when rendering in Gamma space, in Linear space, the error is much smaller.*