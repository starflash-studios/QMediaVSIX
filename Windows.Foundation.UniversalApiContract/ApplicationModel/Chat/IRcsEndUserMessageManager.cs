// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessageManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (RcsEndUserMessageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(810856026, 19743, 19289, 148, 51, 18, 108, 115, 78, 134, 166)]
  internal interface IRcsEndUserMessageManager
  {
    event TypedEventHandler<RcsEndUserMessageManager, RcsEndUserMessageAvailableEventArgs> MessageAvailableChanged;
  }
}
