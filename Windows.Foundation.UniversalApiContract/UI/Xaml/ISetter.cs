// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISetter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(2805853481, 46254, 19073, 190, 133, 230, 144, 186, 13, 59, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Setter))]
  internal interface ISetter
  {
    DependencyProperty Property { get; set; }

    object Value { get; set; }
  }
}
