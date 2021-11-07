// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISecondaryAuthenticationFactorAuthenticationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorAuthenticationTrigger))]
  [Deprecated("SecondaryAuthenticationFactorAuthenticationTrigger is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [Guid(4063752999, 20865, 20260, 150, 167, 112, 10, 78, 95, 172, 98)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISecondaryAuthenticationFactorAuthenticationTrigger : IBackgroundTrigger
  {
  }
}
