// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableObservableVector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Extends IBindableVector by adding a VectorChanged event for change notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4263425334, 32383, 20368, 172, 154, 71, 73, 132, 170, 229, 18)]
  public interface IBindableObservableVector : IBindableVector, IBindableIterable
  {
    /// <summary>Occurs when the vector collection changes (add, delete, item change).</summary>
    event BindableVectorChangedEventHandler VectorChanged;
  }
}
