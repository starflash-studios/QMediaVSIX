// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.AppApplicability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>This class exposes a single static method used to check if a list of App Capabilities is supported on the current device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Static(typeof (IAppApplicabilityStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public static class AppApplicability
  {
    [MethodImpl]
    public static extern IVectorView<UnsupportedAppRequirement> GetUnsupportedAppRequirements(
      IIterable<string> capabilities);
  }
}
