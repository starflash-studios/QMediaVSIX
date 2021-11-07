// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ITickBarStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TickBar))]
  [WebHostHidden]
  [Guid(745373248, 31133, 19028, 190, 9, 31, 239, 198, 29, 1, 142)]
  internal interface ITickBarStatics
  {
    DependencyProperty FillProperty { get; }
  }
}
