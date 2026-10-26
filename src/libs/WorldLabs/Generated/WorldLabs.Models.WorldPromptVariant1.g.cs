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
        ///
        /// </summary>
        public global::WorldLabs.WorldTextPromptOutput PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// For world models generating a world from a single image (+ text).<br/>
        /// Images can be generated using the :image-generation method.<br/>
        /// If no text prompt is provided, it will be generated via recaption.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.Prompt? Image { get; init; }
#else
        public global::WorldLabs.Prompt? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.Prompt? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::WorldLabs.Prompt PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public global::WorldLabs.MultiImagePromptOutput PickMultiImage() => MultiImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MultiImage' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public global::WorldLabs.VideoPromptOutput PickVideo() => Video is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// For models conditioned on a depth pano and text.<br/>
        /// When depth_pano_image is a log-encoded PNG, z_min and z_max are required<br/>
        /// to decode it correctly. When it is an EXR file containing raw float depth<br/>
        /// values, z_min and z_max will both be ignored.<br/>
        /// Please set z_min and z_max both to None when using an EXR file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.DepthPanoPrompt? DepthPano { get; init; }
#else
        public global::WorldLabs.DepthPanoPrompt? DepthPano { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DepthPano))]
#endif
        public bool IsDepthPano => DepthPano != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDepthPano(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.DepthPanoPrompt? value)
        {
            value = DepthPano;
            return IsDepthPano;
        }

        /// <summary>
        ///
        /// </summary>
        public global::WorldLabs.DepthPanoPrompt PickDepthPano() => DepthPano is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DepthPano' but the value was {ToString()}.");

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
        public global::WorldLabs.InpaintPanoPrompt PickInpaintPano() => InpaintPano is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InpaintPano' but the value was {ToString()}.");
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
        public static implicit operator global::WorldLabs.Prompt?(WorldPromptVariant1 @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.Prompt? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorldPromptVariant1 FromImage(global::WorldLabs.Prompt? value) => new WorldPromptVariant1(value);

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
        public static implicit operator global::WorldLabs.DepthPanoPrompt?(WorldPromptVariant1 @this) => @this.DepthPano;

        /// <summary>
        ///
        /// </summary>
        public WorldPromptVariant1(global::WorldLabs.DepthPanoPrompt? value)
        {
            DepthPano = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorldPromptVariant1 FromDepthPano(global::WorldLabs.DepthPanoPrompt? value) => new WorldPromptVariant1(value);

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
            global::WorldLabs.Prompt? image,
            global::WorldLabs.MultiImagePromptOutput? multiImage,
            global::WorldLabs.VideoPromptOutput? video,
            global::WorldLabs.DepthPanoPrompt? depthPano,
            global::WorldLabs.InpaintPanoPrompt? inpaintPano
            )
        {
            Type = type;

            Text = text;
            Image = image;
            MultiImage = multiImage;
            Video = video;
            DepthPano = depthPano;
            InpaintPano = inpaintPano;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InpaintPano as object ??
            DepthPano as object ??
            Video as object ??
            MultiImage as object ??
            Image as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            MultiImage?.ToString() ??
            Video?.ToString() ??
            DepthPano?.ToString() ??
            InpaintPano?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsMultiImage && !IsVideo && !IsDepthPano && !IsInpaintPano || !IsText && IsImage && !IsMultiImage && !IsVideo && !IsDepthPano && !IsInpaintPano || !IsText && !IsImage && IsMultiImage && !IsVideo && !IsDepthPano && !IsInpaintPano || !IsText && !IsImage && !IsMultiImage && IsVideo && !IsDepthPano && !IsInpaintPano || !IsText && !IsImage && !IsMultiImage && !IsVideo && IsDepthPano && !IsInpaintPano || !IsText && !IsImage && !IsMultiImage && !IsVideo && !IsDepthPano && IsInpaintPano;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WorldLabs.WorldTextPromptOutput, TResult>? text = null,
            global::System.Func<global::WorldLabs.Prompt, TResult>? image = null,
            global::System.Func<global::WorldLabs.MultiImagePromptOutput, TResult>? multiImage = null,
            global::System.Func<global::WorldLabs.VideoPromptOutput, TResult>? video = null,
            global::System.Func<global::WorldLabs.DepthPanoPrompt, TResult>? depthPano = null,
            global::System.Func<global::WorldLabs.InpaintPanoPrompt, TResult>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (MultiImage is { } __value2 && multiImage != null)
            {
                return multiImage(__value2);
            }
            else if (Video is { } __value3 && video != null)
            {
                return video(__value3);
            }
            else if (DepthPano is { } __value4 && depthPano != null)
            {
                return depthPano(__value4);
            }
            else if (InpaintPano is { } __value5 && inpaintPano != null)
            {
                return inpaintPano(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::WorldLabs.WorldTextPromptOutput>? text = null,

            global::System.Action<global::WorldLabs.Prompt>? image = null,

            global::System.Action<global::WorldLabs.MultiImagePromptOutput>? multiImage = null,

            global::System.Action<global::WorldLabs.VideoPromptOutput>? video = null,

            global::System.Action<global::WorldLabs.DepthPanoPrompt>? depthPano = null,

            global::System.Action<global::WorldLabs.InpaintPanoPrompt>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (MultiImage is { } __value2)
            {
                multiImage?.Invoke(__value2);
            }
            else if (Video is { } __value3)
            {
                video?.Invoke(__value3);
            }
            else if (DepthPano is { } __value4)
            {
                depthPano?.Invoke(__value4);
            }
            else if (InpaintPano is { } __value5)
            {
                inpaintPano?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::WorldLabs.WorldTextPromptOutput>? text = null,
            global::System.Action<global::WorldLabs.Prompt>? image = null,
            global::System.Action<global::WorldLabs.MultiImagePromptOutput>? multiImage = null,
            global::System.Action<global::WorldLabs.VideoPromptOutput>? video = null,
            global::System.Action<global::WorldLabs.DepthPanoPrompt>? depthPano = null,
            global::System.Action<global::WorldLabs.InpaintPanoPrompt>? inpaintPano = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (MultiImage is { } __value2)
            {
                multiImage?.Invoke(__value2);
            }
            else if (Video is { } __value3)
            {
                video?.Invoke(__value3);
            }
            else if (DepthPano is { } __value4)
            {
                depthPano?.Invoke(__value4);
            }
            else if (InpaintPano is { } __value5)
            {
                inpaintPano?.Invoke(__value5);
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
                Image,
                typeof(global::WorldLabs.Prompt),
                MultiImage,
                typeof(global::WorldLabs.MultiImagePromptOutput),
                Video,
                typeof(global::WorldLabs.VideoPromptOutput),
                DepthPano,
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
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.Prompt?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.MultiImagePromptOutput?>.Default.Equals(MultiImage, other.MultiImage) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.VideoPromptOutput?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.DepthPanoPrompt?>.Default.Equals(DepthPano, other.DepthPano) &&
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
