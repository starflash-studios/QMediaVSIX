// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISocketActivityTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SocketActivityTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2847668240, 40414, 20362, 131, 227, 176, 224, 231, 165, 13, 112)]
  internal interface ISocketActivityTrigger
  {
    bool IsWakeFromLowPowerSupported { get; }
  }
}
