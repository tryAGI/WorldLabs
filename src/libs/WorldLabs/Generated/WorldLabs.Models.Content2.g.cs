#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace WorldLabs
{
    /// <summary>
    /// The content at this location
    /// </summary>
    public readonly partial struct Content2 : global::System.IEquatable<Content2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource? Source { get; }

        /// <summary>
        /// Reference to a previously uploaded MediaAsset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.MediaAssetReference? MediaAsset { get; init; }
#else
        public global::WorldLabs.MediaAssetReference? MediaAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MediaAsset))]
#endif
        public bool IsMediaAsset => MediaAsset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMediaAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.MediaAssetReference? value)
        {
            value = MediaAsset;
            return IsMediaAsset;
        }

        /// <summary>
        /// Reference to content via a publicly accessible URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.UriReference? Uri { get; init; }
#else
        public global::WorldLabs.UriReference? Uri { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Uri))]
#endif
        public bool IsUri => Uri != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUri(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.UriReference? value)
        {
            value = Uri;
            return IsUri;
        }

        /// <summary>
        /// Reference to content via base64-encoded data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::WorldLabs.DataBase64Reference? DataBase64 { get; init; }
#else
        public global::WorldLabs.DataBase64Reference? DataBase64 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DataBase64))]
#endif
        public bool IsDataBase64 => DataBase64 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDataBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::WorldLabs.DataBase64Reference? value)
        {
            value = DataBase64;
            return IsDataBase64;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content2(global::WorldLabs.MediaAssetReference value) => new Content2((global::WorldLabs.MediaAssetReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.MediaAssetReference?(Content2 @this) => @this.MediaAsset;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::WorldLabs.MediaAssetReference? value)
        {
            MediaAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content2(global::WorldLabs.UriReference value) => new Content2((global::WorldLabs.UriReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.UriReference?(Content2 @this) => @this.Uri;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::WorldLabs.UriReference? value)
        {
            Uri = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content2(global::WorldLabs.DataBase64Reference value) => new Content2((global::WorldLabs.DataBase64Reference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::WorldLabs.DataBase64Reference?(Content2 @this) => @this.DataBase64;

        /// <summary>
        /// 
        /// </summary>
        public Content2(global::WorldLabs.DataBase64Reference? value)
        {
            DataBase64 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Content2(
            global::WorldLabs.SphericallyLocatedContentInputContentDiscriminatorSource? source,
            global::WorldLabs.MediaAssetReference? mediaAsset,
            global::WorldLabs.UriReference? uri,
            global::WorldLabs.DataBase64Reference? dataBase64
            )
        {
            Source = source;

            MediaAsset = mediaAsset;
            Uri = uri;
            DataBase64 = dataBase64;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DataBase64 as object ??
            Uri as object ??
            MediaAsset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MediaAsset?.ToString() ??
            Uri?.ToString() ??
            DataBase64?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMediaAsset && !IsUri && !IsDataBase64 || !IsMediaAsset && IsUri && !IsDataBase64 || !IsMediaAsset && !IsUri && IsDataBase64;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::WorldLabs.MediaAssetReference, TResult>? mediaAsset = null,
            global::System.Func<global::WorldLabs.UriReference, TResult>? uri = null,
            global::System.Func<global::WorldLabs.DataBase64Reference, TResult>? dataBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMediaAsset && mediaAsset != null)
            {
                return mediaAsset(MediaAsset!);
            }
            else if (IsUri && uri != null)
            {
                return uri(Uri!);
            }
            else if (IsDataBase64 && dataBase64 != null)
            {
                return dataBase64(DataBase64!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::WorldLabs.MediaAssetReference>? mediaAsset = null,

            global::System.Action<global::WorldLabs.UriReference>? uri = null,

            global::System.Action<global::WorldLabs.DataBase64Reference>? dataBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMediaAsset)
            {
                mediaAsset?.Invoke(MediaAsset!);
            }
            else if (IsUri)
            {
                uri?.Invoke(Uri!);
            }
            else if (IsDataBase64)
            {
                dataBase64?.Invoke(DataBase64!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::WorldLabs.MediaAssetReference>? mediaAsset = null,
            global::System.Action<global::WorldLabs.UriReference>? uri = null,
            global::System.Action<global::WorldLabs.DataBase64Reference>? dataBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMediaAsset)
            {
                mediaAsset?.Invoke(MediaAsset!);
            }
            else if (IsUri)
            {
                uri?.Invoke(Uri!);
            }
            else if (IsDataBase64)
            {
                dataBase64?.Invoke(DataBase64!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MediaAsset,
                typeof(global::WorldLabs.MediaAssetReference),
                Uri,
                typeof(global::WorldLabs.UriReference),
                DataBase64,
                typeof(global::WorldLabs.DataBase64Reference),
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
        public bool Equals(Content2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.MediaAssetReference?>.Default.Equals(MediaAsset, other.MediaAsset) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.UriReference?>.Default.Equals(Uri, other.Uri) &&
                global::System.Collections.Generic.EqualityComparer<global::WorldLabs.DataBase64Reference?>.Default.Equals(DataBase64, other.DataBase64) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content2 obj1, Content2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content2 obj1, Content2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content2 o && Equals(o);
        }
    }
}
