// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.StandardDataFormats
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Contains static properties that return string values. Each string corresponds to a known format ID. Use this class to avoid errors in using string constants to specify data formats.</summary>
  [Static(typeof (IStandardDataFormatsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStandardDataFormatsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStandardDataFormatsStatics3), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public static class StandardDataFormats
  {
    /// <summary>A read-only property that returns the format ID string value corresponding to the UserActivity JSON array format.</summary>
    /// <returns>The format ID string value corresponding to the UserActivity JSON array format.</returns>
    public static extern string UserActivityJsonArray { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the web link format.</summary>
    /// <returns>The format ID string value corresponding to the web link format.</returns>
    public static extern string WebLink { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the activation link format.</summary>
    /// <returns>The format ID string value corresponding to the application link format.</returns>
    public static extern string ApplicationLink { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the Text format.</summary>
    /// <returns>The format ID string value corresponding to the Text format.</returns>
    public static extern string Text { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the Uniform Resource Identifier (URI) format.</summary>
    /// <returns>The format ID string value corresponding to the Uniform Resource Identifier (URI) format.</returns>
    public static extern string Uri { [Deprecated("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the HTML format.</summary>
    /// <returns>The format ID string value corresponding to the HTML format.</returns>
    public static extern string Html { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the Rich Text Format (RTF).</summary>
    /// <returns>The format ID string value corresponding to the Rich Text Format (RTF) format.</returns>
    public static extern string Rtf { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the Bitmap format.</summary>
    /// <returns>The format ID string value corresponding to the Bitmap format.</returns>
    public static extern string Bitmap { [MethodImpl] get; }

    /// <summary>A read-only property that returns the format ID string value corresponding to the StorageItem format.</summary>
    /// <returns>The format ID string value corresponding to the StorageItem format.</returns>
    public static extern string StorageItems { [MethodImpl] get; }
  }
}
