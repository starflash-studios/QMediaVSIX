// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SystemTrigger))]
  [Guid(3892585428, 34705, 17785, 129, 38, 135, 236, 138, 170, 64, 122)]
  internal interface ISystemTriggerFactory
  {
    SystemTrigger Create(SystemTriggerType triggerType, bool oneShot);
  }
}
