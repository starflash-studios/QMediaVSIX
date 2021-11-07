// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (DisplayInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3201372846, 44483, 19913, 174, 101, 133, 31, 77, 125, 71, 153)]
  internal interface IDisplayInformation
  {
    DisplayOrientations CurrentOrientation { get; }

    DisplayOrientations NativeOrientation { get; }

    event TypedEventHandler<DisplayInformation, object> OrientationChanged;

    ResolutionScale ResolutionScale { get; }

    float LogicalDpi { get; }

    float RawDpiX { get; }

    float RawDpiY { get; }

    event TypedEventHandler<DisplayInformation, object> DpiChanged;

    bool StereoEnabled { get; }

    event TypedEventHandler<DisplayInformation, object> StereoEnabledChanged;

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    event TypedEventHandler<DisplayInformation, object> ColorProfileChanged;
  }
}
