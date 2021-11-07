// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.BindableVectorChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Represents the method that will handle the VectorChanged event.</summary>
  /// <param name="vector">The object where the handler is attached.</param>
  /// <param name="e">Event data, loosely typed.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1649202401, 53255, 17329, 156, 3, 175, 77, 62, 98, 88, 196)]
  public delegate void BindableVectorChangedEventHandler(IBindableObservableVector vector, object e);
}
