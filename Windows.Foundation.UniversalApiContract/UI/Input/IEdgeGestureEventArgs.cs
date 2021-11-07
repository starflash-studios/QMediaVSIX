// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IEdgeGestureEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1157253668, 11529, 17121, 139, 94, 54, 130, 8, 121, 106, 76)]
  [ExclusiveTo(typeof (EdgeGestureEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEdgeGestureEventArgs
  {
    EdgeGestureKind Kind { get; }
  }
}
