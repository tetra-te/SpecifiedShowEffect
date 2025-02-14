using System.Numerics;
using Vortice.Direct2D1;
using YukkuriMovieMaker.Player.Video;

namespace SpecifiedShowEffect.Effects
{
    internal class SpecifiedShowEffectProcessor : IVideoEffectProcessor
    {
        readonly SpecifiedShowEffect item;
        ID2D1Image? input;

        public ID2D1Image Output => input ?? throw new NullReferenceException(nameof(input) + "is null");

        public SpecifiedShowEffectProcessor(SpecifiedShowEffect item)
        {
            this.item = item;
        }

        public DrawDescription Update(EffectDescription effectDescription)
        {
            double opacity = 1;

            switch (effectDescription.Usage)
            {
                case TimelineSourceUsage.Playing:
                    opacity = item.Playing / 100;
                    break;
                case TimelineSourceUsage.Paused:
                    opacity = item.Paused / 100;
                    break;
                case TimelineSourceUsage.Exporting:
                    opacity = item.Exporting / 100;
                    break;
            }

            var drawDesc = effectDescription.DrawDescription;

            return
                drawDesc with
                {
                    Opacity = drawDesc.Opacity * opacity,
                };
        }
        public void ClearInput()
        {
            input = null;
        }
        public void SetInput(ID2D1Image? input)
        {
            this.input = input;
        }

        public void Dispose()
        {

        }

    }
}