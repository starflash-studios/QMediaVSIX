// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapCodecInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Provides access to information about a decoder or encoder.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapCodecInformation : IBitmapCodecInformation
  {
    /// <summary>The unique identifier of the decoder or encoder. Methods like BitmapDecoder.CreateAsync and BitmapEncoder.CreateAsync use the codec identifier to determine which codec to create.</summary>
    /// <returns>The codec unique identifier.</returns>
    public extern Guid CodecId { [MethodImpl] get; }

    /// <summary>A collection of all the file extensions supported by the decoder or encoder.</summary>
    /// <returns>The list of supported file extensions.</returns>
    public extern IVectorView<string> FileExtensions { [MethodImpl] get; }

    /// <summary>The friendly name of the decoder or encoder.</summary>
    /// <returns>The friendly name of the codec.</returns>
    public extern string FriendlyName { [MethodImpl] get; }

    /// <summary>A collection of all the MIME/content types supported by the decoder or encoder. MIME type is synonymous with content type.</summary>
    /// <returns>The list of supported MIME/content types.</returns>
    public extern IVectorView<string> MimeTypes { [MethodImpl] get; }
  }
}
