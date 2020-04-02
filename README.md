# unity_urp_modified
modified Unity URP 7.3.1

+ resume support for CameraClearFlags.DepthOnly.
+ option to grab rendered texture after transparent rendering.
+ per camera render scale (\*1)
+ shadowmask (\*2 \*3)
+ directional additional light shadow casting

[Unity Companion License](https://unity3d.com/legal/licenses/Unity_Companion_License)

*\*1 Implemented through blit with blending. Due to 1. gamma blending 2. premultipled alpha, a ~2.5% error is accumulated when rendering in Gamma space, in Linear space, the error is much smaller.*<br/>
*\*2 Before Unity 2019.3.6, a gap is visible between baked shadow & realtime shadow, along the x&y axis. Due to the way shadow space matrix is calculated.<br/>
*\*3 Distance shadowmask is only applied to main light.<br/>
