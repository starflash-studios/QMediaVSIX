// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IDiagnosticsSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (DiagnosticsSettings))]
  [Guid(3857312973, 10001, 17632, 151, 60, 73, 29, 120, 4, 141, 36)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDiagnosticsSettings
  {
    bool CanUseDiagnosticsToTailorExperiences { get; }

    User User { get; }
  }
}
