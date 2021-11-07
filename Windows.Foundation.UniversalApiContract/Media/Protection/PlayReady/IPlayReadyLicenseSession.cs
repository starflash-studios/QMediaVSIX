// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Creates a media session and binds license acquisition to that media session.</summary>
  [Guid(2708617785, 34810, 20445, 171, 187, 169, 114, 14, 132, 82, 89)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPlayReadyLicenseSession
  {
    /// <summary>Creates a license acquisition service request whose license will be tied to the media session.</summary>
    /// <returns>The license acquisition service request.</returns>
    IPlayReadyLicenseAcquisitionServiceRequest CreateLAServiceRequest();

    /// <summary>Updates the media protection manger with the appropriate settings so the media foundation can be used for playback.</summary>
    /// <param name="mpm">The media protection manager to be updated.</param>
    void ConfigureMediaProtectionManager(MediaProtectionManager mpm);
  }
}
