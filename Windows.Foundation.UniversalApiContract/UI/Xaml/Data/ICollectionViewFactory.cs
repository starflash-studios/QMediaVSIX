// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Supports creation of the relevant ICollectionView implementation.</summary>
  [WebHostHidden]
  [Guid(886352628, 36466, 18768, 145, 146, 236, 208, 125, 57, 157, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICollectionViewFactory
  {
    /// <summary>Creates an ICollectionView instance using default settings.</summary>
    /// <returns>The default view.</returns>
    ICollectionView CreateView();
  }
}
