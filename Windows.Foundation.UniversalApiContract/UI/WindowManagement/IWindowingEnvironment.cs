// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IWindowingEnvironment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (WindowingEnvironment))]
  [WebHostHidden]
  [Guid(641950656, 10825, 21527, 179, 174, 72, 167, 28, 99, 163, 189)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IWindowingEnvironment
  {
    bool IsEnabled { get; }

    WindowingEnvironmentKind Kind { get; }

    IVectorView<DisplayRegion> GetDisplayRegions();

    event TypedEventHandler<WindowingEnvironment, WindowingEnvironmentChangedEventArgs> Changed;
  }
}
