// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreClosestInteractiveBoundsRequested
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4077061178, 59583, 20110, 174, 105, 201, 218, 221, 87, 161, 20)]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [WebHostHidden]
  internal interface ICoreClosestInteractiveBoundsRequested
  {
    event TypedEventHandler<CoreComponentInputSource, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;
  }
}
