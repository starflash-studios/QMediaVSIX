// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ILocationTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(285653767, 65385, 19977, 170, 139, 19, 132, 234, 71, 94, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LocationTrigger))]
  internal interface ILocationTriggerFactory
  {
    LocationTrigger Create(LocationTriggerType triggerType);
  }
}
