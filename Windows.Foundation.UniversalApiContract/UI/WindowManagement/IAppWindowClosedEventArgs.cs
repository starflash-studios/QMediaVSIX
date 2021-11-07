// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (AppWindowClosedEventArgs))]
  [WebHostHidden]
  [Guid(3430807574, 38176, 23046, 130, 30, 69, 106, 216, 179, 88, 170)]
  internal interface IAppWindowClosedEventArgs
  {
    AppWindowClosedReason Reason { get; }
  }
}
