// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToggleButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleButton))]
  [Guid(3580535548, 64639, 17564, 152, 85, 122, 16, 85, 214, 104, 168)]
  internal interface IToggleButtonFactory
  {
    ToggleButton CreateInstance(object baseInterface, out object innerInterface);
  }
}
