// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDropCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1817166216, 38332, 16993, 158, 197, 33, 202, 182, 119, 183, 52)]
  [ExclusiveTo(typeof (DropCompletedEventArgs))]
  internal interface IDropCompletedEventArgs
  {
    DataPackageOperation DropResult { get; }
  }
}
