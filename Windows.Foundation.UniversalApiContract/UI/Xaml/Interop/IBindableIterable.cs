// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableIterable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Extends IIterable to enable data-binding infrastructure requirements.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(57486344, 57129, 16815, 138, 162, 215, 116, 190, 98, 186, 111)]
  public interface IBindableIterable
  {
    /// <summary>Returns a bindable iterator that iterates over the items in the collection.</summary>
    /// <returns>The bindable iterator.</returns>
    IBindableIterator First();
  }
}
