// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the ability to enumerate in-memory-only PlayReady licenses in addition to persisted licenses.</summary>
  [Guid(1225375290, 15085, 18006, 138, 215, 238, 15, 215, 121, 149, 16)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IPlayReadyLicenseSession2 : IPlayReadyLicenseSession
  {
    /// <summary>Creates a PlayReadyLicense object iterator that supports in-memory-only PlayReady licenses in addition to persisted licenses.</summary>
    /// <param name="contentHeader">The content header used to locate associated licenses.</param>
    /// <param name="fullyEvaluated">Indicates whether evaluated license chains should be enumerated or if all licenses (including those that are unusable) should be enumerated. Set this parameter to true if evaluated license chains should be enumerated. Set this parameter to false if all licenses should be enumerated.</param>
    /// <returns>
    /// </returns>
    PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
