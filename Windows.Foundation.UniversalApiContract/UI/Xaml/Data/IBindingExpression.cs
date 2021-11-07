// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingExpression
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(1365907877, 49917, 19102, 159, 211, 154, 164, 47, 153, 90, 60)]
  [ExclusiveTo(typeof (BindingExpression))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBindingExpression
  {
    object DataItem { get; }

    Binding ParentBinding { get; }

    void UpdateSource();
  }
}
