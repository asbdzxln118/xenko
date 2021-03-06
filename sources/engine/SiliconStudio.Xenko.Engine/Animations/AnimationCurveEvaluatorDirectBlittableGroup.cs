using System;
using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Xenko.Animations
{
    public class AnimationCurveEvaluatorDirectBlittableGroup<T> : AnimationCurveEvaluatorDirectBlittableGroupBase<T>
    {
        protected override unsafe void ProcessChannel(ref Channel channel, CompressedTimeSpan newTime, IntPtr location)
        {
            SetTime(ref channel, newTime);

            var keyFrames = channel.Curve.KeyFrames;
            var currentIndex = channel.CurrentIndex;

            Interop.CopyInline((void*)(location + channel.Offset), ref keyFrames.Items[currentIndex].Value);
        }
    }
}