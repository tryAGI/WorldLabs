#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorldPromptVariant1 : global::System.IEquatable<WorldPromptVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Input prompt class for text-conditioned world generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.WorldTextPromptOutput? Text { get; init; }
#else
        public global::WorldLabs.WorldTextPromptOutput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.WorldTextPromptOutput? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// For world models generating a world from a single image (+ text).<br/>
        /// Images can be generated using the :image-generation method.<br/>
        /// If no text prompt is provided, it will be generated via recaption.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.Prompt? DepthPano1 { get; init; }
#else
        public global::WorldLabs.Prompt? DepthPano1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DepthPano1))]
#endif
        public bool IsDepthPano1 => DepthPano1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDepthPano1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.Prompt? value)
        {
            value = DepthPano1;
            return IsDepthPano1;
        }

        /// <summary>
        /// For world models supporting multi-image (+ text) input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.MultiImagePromptOutput? MultiImage { get; init; }
#else
        public global::WorldLabs.MultiImagePromptOutput? MultiImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MultiImage))]
#endif
        public bool IsMultiImage => MultiImage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMultiImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.MultiImagePromptOutput? value)
        {
            value = MultiImage;
            return IsMultiImage;
        }

        /// <summary>
        /// For world models supporting video (+ text) input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.VideoPromptOutput? Video { get; init; }
#else
        public global::WorldLabs.VideoPromptOutput? Video { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.VideoPromptOutput? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// For models conditioned on a depth pano and text.<br/>
        /// When depth_pano_image is a log-encoded PNG, z_min and z_max are required<br/>
        /// to decode it correctly. When it is an EXR file containing raw float depth<br/>
        /// values, z_min and z_max will both be ignored.<br/>
        /// Please set z_min and z_max both to None when using an EXR file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.DepthPanoPrompt? DepthPano2 { get; init; }
#else
        public global::WorldLabs.DepthPanoPrompt? DepthPano2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DepthPano2))]
#endif
        public bool IsDepthPano2 => DepthPano2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDepthPano2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.DepthPanoPrompt? value)
        {
            value = DepthPano2;
            return IsDepthPano2;
        }

        /// <summary>
        /// For models that inpaint the masked portion of a pano image.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.InpaintPanoPrompt? InpaintPano { get; init; }
#else
        public global::WorldLabs.InpaintPanoPrompt? InpaintPano { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InpaintPano))]
#endif
        public bool IsInpaintPano => InpaintPano != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInpaintPano(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.InpaintPanoPrompt? value)
        {
            value = InpaintPano;
            return IsInpaintPano;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.WorldTextPromptOutput value) => new WorldPromptVariant1((global::WorldLabs.WorldTextPromptOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.WorldTextPromptOutput?(WorldPromptVariant1 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.WorldTextPromptOutput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromText(global::WorldLabs.WorldTextPromptOutput? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.Prompt value) => new WorldPromptVariant1((global::WorldLabs.Prompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.Prompt?(WorldPromptVariant1 @this) => @this.DepthPano1;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.Prompt? value)
        {
            DepthPano1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromDepthPano1(global::WorldLabs.Prompt? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.MultiImagePromptOutput value) => new WorldPromptVariant1((global::WorldLabs.MultiImagePromptOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.MultiImagePromptOutput?(WorldPromptVariant1 @this) => @this.MultiImage;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.MultiImagePromptOutput? value)
        {
            MultiImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromMultiImage(global::WorldLabs.MultiImagePromptOutput? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.VideoPromptOutput value) => new WorldPromptVariant1((global::WorldLabs.VideoPromptOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.VideoPromptOutput?(WorldPromptVariant1 @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.VideoPromptOutput? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromVideo(global::WorldLabs.VideoPromptOutput? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.DepthPanoPrompt value) => new WorldPromptVariant1((global::WorldLabs.DepthPanoPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.DepthPanoPrompt?(WorldPromptVariant1 @this) => @this.DepthPano2;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.DepthPanoPrompt? value)
        {
            DepthPano2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromDepthPano2(global::WorldLabs.DepthPanoPrompt? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPromptVariant1(global::WorldLabs.InpaintPanoPrompt value) => new WorldPromptVariant1((global::WorldLabs.InpaintPanoPrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.InpaintPanoPrompt?(WorldPromptVariant1 @this) => @this.InpaintPano;

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.InpaintPanoPrompt? value)
        {
            InpaintPano = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPromptVariant1 FromInpaintPano(global::WorldLabs.InpaintPanoPrompt? value) => new WorldPromptVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public WorldPromptVariant1(
            global::WorldLabs.WorldWorldPromptVariant1DiscriminatorType? type,
            global::WorldLabs.WorldTextPromptOutput? text,
            global::WorldLabs.Prompt? depthPano1,
            global::WorldLabs.MultiImagePromptOutput? multiImage,
            global::WorldLabs.VideoPromptOutput? video,
            global::WorldLabs.DepthPanoPrompt? depthPano2,
            global::WorldLabs.InpaintPanoPrompt? inpaintPano
            )
        {
            Type = type;

            Text = text;
            DepthPano1 = depthPano1;
            MultiImage = multiImage;
            Video = video;
            DepthPano2 = depthPano2;
            InpaintPano = inpaintPano;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InpaintPano as object ??
            DepthPano2 as object ??
            Video as object ??
            MultiImage as object ??
            DepthPano1 as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            DepthPano1?.ToString() ??
            MultiImage?.ToString() ??
            Video?.ToString() ??
            DepthPano2?.ToString() ??
            InpaintPano?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsDepthPano1 && !IsMultiImage && !IsVideo && !IsDepthPano2 && !IsInpaintPano || !IsText && IsDepthPano1 && !IsMultiImage && !IsVideo && !IsDepthPano2 && !IsInpaintPano || !IsText && !IsDepthPano1 && IsMultiImage && !IsVideo && !IsDepthPano2 && !IsInpaintPano || !IsText && !IsDepthPano1 && !IsMultiImage && IsVideo && !IsDepthPano2 && !IsInpaintPano || !IsText && !IsDepthPano1 && !IsMultiImage && !IsVideo && IsDepthPano2 && !IsInpaintPano || !IsText && !IsDepthPano1 && !IsMultiImage && !IsVideo && !IsDepthPano2 && IsInpaintPano;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WorldLabs.WorldTextPromptOutput, TResult>? text = null,
            global::System.Func<global::WorldLabs.Prompt, TResult>? depthPano1 = null,
            global::System.Func<global::WorldLabs.MultiImagePromptOutput, TResult>? multiImage = null,
            global::System.Func<global::WorldLabs.VideoPromptOutput, TResult>? video = null,
            global::System.Func<global::WorldLabs.DepthPanoPrompt, TResult>? depthPano2 = null,
            global::System.Func<global::WorldLabs.InpaintPanoPrompt, TResult>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsDepthPano1 && depthPano1 != null)
            {
                return depthPano1(DepthPano1!);
            }
            else if (IsMultiImage && multiImage != null)
            {
                return multiImage(MultiImage!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsDepthPano2 && depthPano2 != null)
            {
                return depthPano2(DepthPano2!);
            }
            else if (IsInpaintPano && inpaintPano != null)
            {
                return inpaintPano(InpaintPano!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WorldLabs.WorldTextPromptOutput>? text = null,

            global::System.Action<global::WorldLabs.Prompt>? depthPano1 = null,

            global::System.Action<global::WorldLabs.MultiImagePromptOutput>? multiImage = null,

            global::System.Action<global::WorldLabs.VideoPromptOutput>? video = null,

            global::System.Action<global::WorldLabs.DepthPanoPrompt>? depthPano2 = null,

            global::System.Action<global::WorldLabs.InpaintPanoPrompt>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsDepthPano1)
            {
                depthPano1?.Invoke(DepthPano1!);
            }
            else if (IsMultiImage)
            {
                multiImage?.Invoke(MultiImage!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsDepthPano2)
            {
                depthPano2?.Invoke(DepthPano2!);
            }
            else if (IsInpaintPano)
            {
                inpaintPano?.Invoke(InpaintPano!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::WorldLabs.WorldTextPromptOutput>? text = null,
            global::System.Action<global::WorldLabs.Prompt>? depthPano1 = null,
            global::System.Action<global::WorldLabs.MultiImagePromptOutput>? multiImage = null,
            global::System.Action<global::WorldLabs.VideoPromptOutput>? video = null,
            global::System.Action<global::WorldLabs.DepthPanoPrompt>? depthPano2 = null,
            global::System.Action<global::WorldLabs.InpaintPanoPrompt>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsDepthPano1)
            {
                depthPano1?.Invoke(DepthPano1!);
            }
            else if (IsMultiImage)
            {
                multiImage?.Invoke(MultiImage!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsDepthPano2)
            {
                depthPano2?.Invoke(DepthPano2!);
            }
            else if (IsInpaintPano)
            {
                inpaintPano?.Invoke(InpaintPano!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::WorldLabs.WorldTextPromptOutput),
                DepthPano1,
                typeof(global::WorldLabs.Prompt),
                MultiImage,
                typeof(global::WorldLabs.MultiImagePromptOutput),
                Video,
                typeof(global::WorldLabs.VideoPromptOutput),
                DepthPano2,
                typeof(global::WorldLabs.DepthPanoPrompt),
                InpaintPano,
                typeof(global::WorldLabs.InpaintPanoPrompt),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(WorldPromptVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.WorldTextPromptOutput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.Prompt?>.Default.Equals(DepthPano1, other.DepthPano1) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.MultiImagePromptOutput?>.Default.Equals(MultiImage, other.MultiImage) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.VideoPromptOutput?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.DepthPanoPrompt?>.Default.Equals(DepthPano2, other.DepthPano2) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.InpaintPanoPrompt?>.Default.Equals(InpaintPano, other.InpaintPano) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorldPromptVariant1 obj1, WorldPromptVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorldPromptVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorldPromptVariant1 obj1, WorldPromptVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorldPromptVariant1 o && Equals(o);
        }
    }
}
