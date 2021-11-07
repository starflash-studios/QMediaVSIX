// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverVideoStreamSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverVideoStreamSettings))]
  [Guid(379280923, 5277, 21200, 177, 38, 111, 137, 116, 78, 79, 80)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverVideoStreamSettings
  {
    SizeInt32 Size { get; set; }

    int Bitrate { get; set; }
  }
}
