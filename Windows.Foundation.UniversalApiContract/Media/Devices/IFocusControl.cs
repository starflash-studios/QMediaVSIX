// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFocusControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3235416566, 21032, 17491, 177, 83, 133, 96, 101, 146, 178, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FocusControl))]
  internal interface IFocusControl
  {
    bool Supported { get; }

    IVectorView<FocusPreset> SupportedPresets { get; }

    FocusPreset Preset { get; }

    [Overload("SetPresetAsync")]
    [RemoteAsync]
    IAsyncAction SetPresetAsync(FocusPreset preset);

    [Overload("SetPresetWithCompletionOptionAsync")]
    [RemoteAsync]
    IAsyncAction SetPresetAsync(FocusPreset preset, bool completeBeforeFocus);

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }

    uint Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(uint focus);

    [RemoteAsync]
    IAsyncAction FocusAsync();
  }
}
