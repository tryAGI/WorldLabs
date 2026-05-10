#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// The prompt specifying how to generate the world
    /// </summary>
    public readonly partial struct WorldPrompt : global::System.IEquatable<WorldPrompt>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType? Type { get; }

        /// <summary>
        /// Text-to-world generation.<br/>
        /// Generates a world from a text description. text_prompt is REQUIRED.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.WorldTextPromptInput? Text { get; init; }
#else
        public global::WorldLabs.WorldTextPromptInput? Text { get; }
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
            out global::WorldLabs.WorldTextPromptInput? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// Image-to-world generation.<br/>
        /// Generates a world from an image. text_prompt is optional - if not provided,<br/>
        /// it will be generated via recaptioning.<br/>
        /// Recommended image formats: jpg, jpeg, png, webp.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.ImagePrompt? Image { get; init; }
#else
        public global::WorldLabs.ImagePrompt? Image { get; }
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
            out global::WorldLabs.ImagePrompt? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// Multi-image-to-world generation.<br/>
        /// Generates a world from multiple images. text_prompt is optional.<br/>
        /// Recommended image formats: jpg, jpeg, png, webp.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.MultiImagePromptInput? MultiImage { get; init; }
#else
        public global::WorldLabs.MultiImagePromptInput? MultiImage { get; }
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
            out global::WorldLabs.MultiImagePromptInput? value)
        {
            value = MultiImage;
            return IsMultiImage;
        }

        /// <summary>
        /// Video-to-world generation.<br/>
        /// Generates a world from a video. text_prompt is optional.<br/>
        /// Recommended video formats: mp4, webm, mov, avi.<br/>
        /// Maximum video size: 100MB.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.VideoPromptInput? Video { get; init; }
#else
        public global::WorldLabs.VideoPromptInput? Video { get; }
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
            out global::WorldLabs.VideoPromptInput? value)
        {
            value = Video;
            return IsVideo;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPrompt(global::WorldLabs.WorldTextPromptInput value) => new WorldPrompt((global::WorldLabs.WorldTextPromptInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.WorldTextPromptInput?(WorldPrompt @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public WorldPrompt(global::WorldLabs.WorldTextPromptInput? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPrompt FromText(global::WorldLabs.WorldTextPromptInput? value) => new WorldPrompt(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPrompt(global::WorldLabs.ImagePrompt value) => new WorldPrompt((global::WorldLabs.ImagePrompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.ImagePrompt?(WorldPrompt @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public WorldPrompt(global::WorldLabs.ImagePrompt? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPrompt FromImage(global::WorldLabs.ImagePrompt? value) => new WorldPrompt(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPrompt(global::WorldLabs.MultiImagePromptInput value) => new WorldPrompt((global::WorldLabs.MultiImagePromptInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.MultiImagePromptInput?(WorldPrompt @this) => @this.MultiImage;

        /// <summary>
        /// 
        /// </summary>
        public WorldPrompt(global::WorldLabs.MultiImagePromptInput? value)
        {
            MultiImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPrompt FromMultiImage(global::WorldLabs.MultiImagePromptInput? value) => new WorldPrompt(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorldPrompt(global::WorldLabs.VideoPromptInput value) => new WorldPrompt((global::WorldLabs.VideoPromptInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.VideoPromptInput?(WorldPrompt @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public WorldPrompt(global::WorldLabs.VideoPromptInput? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorldPrompt FromVideo(global::WorldLabs.VideoPromptInput? value) => new WorldPrompt(value);

        /// <summary>
        /// 
        /// </summary>
        public WorldPrompt(
            global::WorldLabs.WorldsGenerateRequestWorldPromptDiscriminatorType? type,
            global::WorldLabs.WorldTextPromptInput? text,
            global::WorldLabs.ImagePrompt? image,
            global::WorldLabs.MultiImagePromptInput? multiImage,
            global::WorldLabs.VideoPromptInput? video
            )
        {
            Type = type;

            Text = text;
            Image = image;
            MultiImage = multiImage;
            Video = video;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Video?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsMultiImage && !IsVideo || !IsText && IsImage && !IsMultiImage && !IsVideo || !IsText && !IsImage && IsMultiImage && !IsVideo || !IsText && !IsImage && !IsMultiImage && IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WorldLabs.WorldTextPromptInput, TResult>? text = null,
            global::System.Func<global::WorldLabs.ImagePrompt, TResult>? image = null,
            global::System.Func<global::WorldLabs.MultiImagePromptInput, TResult>? multiImage = null,
            global::System.Func<global::WorldLabs.VideoPromptInput, TResult>? video = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsMultiImage && multiImage != null)
            {
                return multiImage(MultiImage!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WorldLabs.WorldTextPromptInput>? text = null,

            global::System.Action<global::WorldLabs.ImagePrompt>? image = null,

            global::System.Action<global::WorldLabs.MultiImagePromptInput>? multiImage = null,

            global::System.Action<global::WorldLabs.VideoPromptInput>? video = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMultiImage)
            {
                multiImage?.Invoke(MultiImage!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::WorldLabs.WorldTextPromptInput>? text = null,
            global::System.Action<global::WorldLabs.ImagePrompt>? image = null,
            global::System.Action<global::WorldLabs.MultiImagePromptInput>? multiImage = null,
            global::System.Action<global::WorldLabs.VideoPromptInput>? video = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsMultiImage)
            {
                multiImage?.Invoke(MultiImage!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
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
                typeof(global::WorldLabs.WorldTextPromptInput),
                Image,
                typeof(global::WorldLabs.ImagePrompt),
                MultiImage,
                typeof(global::WorldLabs.MultiImagePromptInput),
                Video,
                typeof(global::WorldLabs.VideoPromptInput),
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
        public bool Equals(WorldPrompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.WorldTextPromptInput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.ImagePrompt?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.MultiImagePromptInput?>.Default.Equals(MultiImage, other.MultiImage) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.VideoPromptInput?>.Default.Equals(Video, other.Video) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorldPrompt obj1, WorldPrompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorldPrompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorldPrompt obj1, WorldPrompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorldPrompt o && Equals(o);
        }
    }
}
