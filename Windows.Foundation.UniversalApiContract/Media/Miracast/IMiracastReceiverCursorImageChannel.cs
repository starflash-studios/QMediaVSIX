// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverCursorImageChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Storage.Streams;

namespace Windows.Media.Miracast
{
  [Guid(3651941165, 29242, 23197, 185, 10, 129, 21, 62, 250, 42, 15)]
  [ExclusiveTo(typeof (MiracastReceiverCursorImageChannel))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverCursorImageChannel
  {
    bool IsEnabled { get; }

    SizeInt32 MaxImageSize { get; }

    PointInt32 Position { get; }

    IRandomAccessStreamWithContentType ImageStream { get; }

    event TypedEventHandler<MiracastReceiverCursorImageChannel, object> ImageStreamChanged;

    event TypedEventHandler<MiracastReceiverCursorImageChannel, object> PositionChanged;
  }
}
