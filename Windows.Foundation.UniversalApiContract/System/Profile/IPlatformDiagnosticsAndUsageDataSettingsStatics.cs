// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IPlatformDiagnosticsAndUsageDataSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3068283931, 31516, 19250, 140, 98, 166, 101, 151, 206, 114, 58)]
  [ExclusiveTo(typeof (PlatformDiagnosticsAndUsageDataSettings))]
  internal interface IPlatformDiagnosticsAndUsageDataSettingsStatics
  {
    PlatformDataCollectionLevel CollectionLevel { get; }

    event EventHandler<object> CollectionLevelChanged;

    bool CanCollectDiagnostics(PlatformDataCollectionLevel level);
  }
}
