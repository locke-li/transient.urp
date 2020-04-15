using System;

namespace UnityEngine.Rendering.Universal.Internal
{
    /// <summary>
    /// Force a depth clear
    /// </summary>
    public class ClearDepthPass : ScriptableRenderPass
    {
        public ClearDepthPass(RenderPassEvent evt)
        {
            renderPassEvent = evt;
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
            ConfigureClear(ClearFlag.Depth, Color.clear);
        }

        /// <inheritdoc/>
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }
    }
}
