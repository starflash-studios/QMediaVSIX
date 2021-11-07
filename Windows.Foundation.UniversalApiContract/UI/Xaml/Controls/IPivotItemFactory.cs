// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(231659905, 25454, 18996, 138, 63, 142, 224, 24, 99, 146, 133)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PivotItem))]
  internal interface IPivotItemFactory
  {
    PivotItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
