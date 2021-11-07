// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusControl2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FocusControl))]
  [Guid(1065156424, 50484, 20126, 148, 195, 82, 239, 42, 253, 93, 7)]
  internal interface IFocusControl2
  {
    bool FocusChangedSupported { get; }

    bool WaitForFocusSupported { get; }

    IVectorView<FocusMode> SupportedFocusModes { get; }

    IVectorView<ManualFocusDistance> SupportedFocusDistances { get; }

    IVectorView<AutoFocusRange> SupportedFocusRanges { get; }

    FocusMode Mode { get; }

    MediaCaptureFocusState FocusState { get; }

    [RemoteAsync]
    IAsyncAction UnlockAsync();

    [RemoteAsync]
    IAsyncAction LockAsync();

    void Configure(FocusSettings settings);
  }
}
