// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1961475617, 24034, 22878, 188, 8, 219, 211, 197, 119, 73, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [WebHostHidden]
  internal interface IScrollViewer3
  {
    event EventHandler<object> DirectManipulationStarted;

    event EventHandler<object> DirectManipulationCompleted;
  }
}
