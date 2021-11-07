// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (CollectionViewSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2791969094, 54011, 20141, 190, 159, 53, 120, 164, 102, 220, 254)]
  [WebHostHidden]
  internal interface ICollectionViewSource
  {
    object Source { get; set; }

    ICollectionView View { get; }

    bool IsSourceGrouped { get; set; }

    PropertyPath ItemsPath { get; set; }
  }
}
