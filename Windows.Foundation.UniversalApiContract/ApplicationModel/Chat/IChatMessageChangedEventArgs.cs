// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(3065462317, 26908, 20191, 134, 96, 110, 185, 137, 104, 146, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageChangedEventArgs))]
  internal interface IChatMessageChangedEventArgs
  {
    ChatMessageChangedDeferral GetDeferral();
  }
}
