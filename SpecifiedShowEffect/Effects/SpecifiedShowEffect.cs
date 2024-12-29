using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using YukkuriMovieMaker.Commons;
using YukkuriMovieMaker.Controls;
using YukkuriMovieMaker.Exo;
using YukkuriMovieMaker.Player.Video;
using YukkuriMovieMaker.Plugin.Effects;

namespace SpecifiedShowEffect.Effects
{
    [VideoEffect("指定時にのみ表示", ["描画"], [], isAviUtlSupported: false)]
    internal class SpecifiedShowEffect : VideoEffectBase
    {
        public override string Label => "指定時にのみ表示";

        [Display(GroupName = "不透明度", Name = "再生時", Description = "プレビューの再生中の不透明度")]
        [TextBoxSlider("F1", "%", 0, 100)]
        [DefaultValue(100d)]
        [Range(0, 100)]
        public double Playing { get => playing; set => Set(ref playing, value); }
        double playing = 100;

        [Display(GroupName = "不透明度", Name = "一時停止時", Description = "プレビューの一時停止中の不透明度")]
        [TextBoxSlider("F1", "%", 0, 100)]
        [DefaultValue(100d)]
        [Range(0, 100)]
        public double Paused { get => paused; set => Set(ref paused, value); }
        double paused = 100;

        [Display(GroupName = "不透明度", Name = "出力時", Description = "動画の出力中の不透明度")]
        [TextBoxSlider("F1", "%", 0, 100)]
        [DefaultValue(100d)]
        [Range(0, 100)]
        public double Exporting { get => exporting; set => Set(ref exporting, value); }
        double exporting = 100;

        [Display(Name = "最適化", Description = "不透明度が0%の時に拡大率も0%にして高速化します")]
        [ToggleSlider]
        public bool OptimizedHiding { get => optimizedHiding; set => Set(ref optimizedHiding, value); }
        bool optimizedHiding = true;

        public override IEnumerable<string> CreateExoVideoFilters(int keyFrameIndex, ExoOutputDescription exoOutputDescription)
        {
            return [];
        }

        public override IVideoEffectProcessor CreateVideoEffect(IGraphicsDevicesAndContext devices)
        {
            return new SpecifiedShowEffectProcessor(this);
        }

        protected override IEnumerable<IAnimatable> GetAnimatables() => [];
    }
}
