// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Encapsulates the method needed to set the configuration properties on a registered media parser or codec.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(126963992, 17887, 17451, 138, 63, 247, 130, 106, 99, 112, 171)]
  public interface IMediaExtension
  {
    /// <summary>Sets the configuration properties that were supplied when the media parser or codec was registered.</summary>
    /// <param name="configuration">The configuration properties for the media parser or codec.</param>
    void SetProperties(IPropertySet configuration);
  }
}
