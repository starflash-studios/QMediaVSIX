// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicenseIterable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Exposes the PlayReadyLicense class iterator.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPlayReadyLicenseIterableFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadyLicenseIterable : IIterable<IPlayReadyLicense>
  {
    /// <summary>Initializes a new instance of the PlayReadyLicenseIterable class.</summary>
    [MethodImpl]
    public extern PlayReadyLicenseIterable();

    /// <summary>Initializes a new instance of the PlayReadyLicenseIterable class.</summary>
    /// <param name="contentHeader">The content header used to locate associated licenses.</param>
    /// <param name="fullyEvaluated">Indicates whether evaluated license chains should be enumerated or if all licenses (including those that are unusable) should be enumerated. This parameter is **true** if evaluated license chains should be enumerated, or **false** if all licenses should be enumerated.</param>
    [MethodImpl]
    public extern PlayReadyLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);

    [MethodImpl]
    public extern IIterator<IPlayReadyLicense> First();
  }
}
