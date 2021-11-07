// Decompiled with JetBrains decompiler
// Type: Windows.Media.ImageDisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides properties for image information that is displayed by SystemMediaTransportControlsDisplayUpdater class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ImageDisplayProperties : IImageDisplayProperties
  {
    /// <summary>Gets or sets the title of the image.</summary>
    /// <returns>The title of the image.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the subtitle of the image.</summary>
    /// <returns>The subtitle of the image.</returns>
    public extern string Subtitle { [MethodImpl] get; [MethodImpl] set; }
  }
}
