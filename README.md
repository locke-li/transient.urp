# transient_urp
Customized Unity URP

+ =Vanilla stack/overlay camera should work properly.
+ \+CameraClearFlags.DepthOnly support resumed.
+ \+Option to grab rendered texture after transparent rendering.
+ \+Per camera render scale \*1
+ \+Shadowmask/Distance Shadowmask \*2
+ \+Directional additional light shadow casting \*3

[Unity Companion License](https://unity3d.com/legal/licenses/Unity_Companion_License)

*\*1 Implemented through blit with blending. Due to 1. gamma blending 2. premultipled alpha, a ~2.5% error is accumulated when rendering in Gamma space, in Linear space, the error is much smaller.*<br/>
*\*2 Force shadow mixing in distance shadowmask mode to avoid gap artefact.*<br/>
*\*3 Shadow cascade not implemented.*<br/>
*\*4 Package identifier remains "com.unity.render-pipelines.universal" for compatibility