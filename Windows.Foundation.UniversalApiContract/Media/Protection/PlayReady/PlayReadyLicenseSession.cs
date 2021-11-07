// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Creates a media session and binds license acquisition to that media session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPlayReadyLicenseSessionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadyLicenseSession : IPlayReadyLicenseSession, IPlayReadyLicenseSession2
  {
    /// <summary>Initializes a new instance of the PlayReadyLicenseSession class.</summary>
    /// <param name="configuration">The configuration data for the license session.</param>
    [MethodImpl]
    public extern PlayReadyLicenseSession(IPropertySet configuration);

    /// <summary>Creates a license acquisition service request whose license will be tied to the media session.</summary>
    /// <returns>The license acquisition service request.</returns>
    [MethodImpl]
    public extern IPlayReadyLicenseAcquisitionServiceRequest CreateLAServiceRequest();

    /// <summary>Updates the media protection manger with the appropriate settings so the media foundation can be used for playback.</summary>
    /// <param name="mpm">The media protection manager to be updated.</param>
    [MethodImpl]
    public extern void ConfigureMediaProtectionManager(MediaProtectionManager mpm);

    /// <summary>Creates a PlayReadyLicense class iterator that supports in-memory-only PlayReady licenses in addition to persisted licenses.</summary>
    /// <param name="contentHeader">The content header used to locate associated licenses.</param>
    /// <param name="fullyEvaluated">Indicates whether evaluated license chains should be enumerated or if all licenses (including those that are unusable) should be enumerated. Set this parameter to true if evaluated license chains should be enumerated. Set this parameter to false if all licenses should be enumerated.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
