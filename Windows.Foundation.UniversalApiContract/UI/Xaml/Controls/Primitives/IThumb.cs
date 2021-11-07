// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IThumb
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (Thumb))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3904025217, 3434, 17871, 179, 51, 36, 2, 176, 55, 240, 153)]
  [WebHostHidden]
  internal interface IThumb
  {
    bool IsDragging { get; }

    event DragStartedEventHandler DragStarted;

    event DragDeltaEventHandler DragDelta;

    event DragCompletedEventHandler DragCompleted;

    void CancelDrag();
  }
}
