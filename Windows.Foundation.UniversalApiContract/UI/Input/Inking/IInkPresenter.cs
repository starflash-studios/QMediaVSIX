// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2795204834, 34939, 17807, 177, 115, 79, 228, 67, 137, 48, 163)]
  [ExclusiveTo(typeof (InkPresenter))]
  internal interface IInkPresenter
  {
    bool IsInputEnabled { get; set; }

    CoreInputDeviceTypes InputDeviceTypes { get; set; }

    InkUnprocessedInput UnprocessedInput { get; }

    InkStrokeInput StrokeInput { get; }

    InkInputProcessingConfiguration InputProcessingConfiguration { get; }

    InkStrokeContainer StrokeContainer { get; set; }

    InkDrawingAttributes CopyDefaultDrawingAttributes();

    void UpdateDefaultDrawingAttributes(InkDrawingAttributes value);

    InkSynchronizer ActivateCustomDrying();

    void SetPredefinedConfiguration(InkPresenterPredefinedConfiguration value);

    event TypedEventHandler<InkPresenter, InkStrokesCollectedEventArgs> StrokesCollected;

    event TypedEventHandler<InkPresenter, InkStrokesErasedEventArgs> StrokesErased;
  }
}
