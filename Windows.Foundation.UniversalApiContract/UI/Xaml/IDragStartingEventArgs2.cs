// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragStartingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragStartingEventArgs))]
  [Guid(3629506702, 17590, 16913, 189, 11, 127, 221, 187, 110, 130, 49)]
  internal interface IDragStartingEventArgs2
  {
    DataPackageOperation AllowedOperations { get; set; }
  }
}
