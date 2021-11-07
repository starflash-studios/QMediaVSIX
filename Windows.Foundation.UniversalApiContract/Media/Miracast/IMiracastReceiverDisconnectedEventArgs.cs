// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverDisconnectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3651231326, 24558, 22502, 180, 176, 4, 114, 125, 185, 50, 41)]
  [ExclusiveTo(typeof (MiracastReceiverDisconnectedEventArgs))]
  internal interface IMiracastReceiverDisconnectedEventArgs
  {
    MiracastReceiverConnection Connection { get; }
  }
}
