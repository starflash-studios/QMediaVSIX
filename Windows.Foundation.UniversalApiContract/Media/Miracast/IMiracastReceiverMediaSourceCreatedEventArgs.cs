// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverMediaSourceCreatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Miracast
{
  [Guid(399462814, 4678, 21277, 148, 90, 107, 21, 142, 57, 195, 170)]
  [ExclusiveTo(typeof (MiracastReceiverMediaSourceCreatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverMediaSourceCreatedEventArgs
  {
    MiracastReceiverConnection Connection { get; }

    MediaSource MediaSource { get; }

    MiracastReceiverCursorImageChannelSettings CursorImageChannelSettings { get; }

    Deferral GetDeferral();
  }
}
