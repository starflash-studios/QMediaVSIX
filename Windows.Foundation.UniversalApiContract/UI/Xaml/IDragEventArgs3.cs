// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DragEventArgs))]
  [Guid(3494888390, 33049, 17018, 129, 82, 95, 149, 80, 204, 4, 22)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDragEventArgs3
  {
    DataPackageOperation AllowedOperations { get; }
  }
}
