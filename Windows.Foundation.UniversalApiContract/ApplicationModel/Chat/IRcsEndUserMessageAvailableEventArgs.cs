// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsEndUserMessageAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(759541249, 16265, 16874, 151, 2, 158, 158, 212, 17, 170, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsEndUserMessageAvailableEventArgs))]
  internal interface IRcsEndUserMessageAvailableEventArgs
  {
    bool IsMessageAvailable { get; }

    RcsEndUserMessage Message { get; }
  }
}
