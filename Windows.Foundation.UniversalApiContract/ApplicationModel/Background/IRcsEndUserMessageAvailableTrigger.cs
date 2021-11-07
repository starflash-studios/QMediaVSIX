// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IRcsEndUserMessageAvailableTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(2557283690, 45814, 18047, 169, 120, 164, 64, 145, 193, 26, 102)]
  [ExclusiveTo(typeof (RcsEndUserMessageAvailableTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRcsEndUserMessageAvailableTrigger : IBackgroundTrigger
  {
  }
}
