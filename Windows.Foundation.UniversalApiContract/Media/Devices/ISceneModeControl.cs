// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ISceneModeControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (SceneModeControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3566099191, 36185, 18516, 140, 98, 18, 199, 11, 168, 155, 124)]
  internal interface ISceneModeControl
  {
    IVectorView<CaptureSceneMode> SupportedModes { get; }

    CaptureSceneMode Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(CaptureSceneMode sceneMode);
  }
}
