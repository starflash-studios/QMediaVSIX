// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IDiagnosticsSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (DiagnosticsSettings))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1926424591, 21392, 18323, 153, 11, 60, 204, 125, 106, 201, 200)]
  internal interface IDiagnosticsSettingsStatics
  {
    DiagnosticsSettings GetDefault();

    DiagnosticsSettings GetForUser(User user);
  }
}
