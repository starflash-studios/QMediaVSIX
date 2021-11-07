// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreTouchHitTesting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2983764617, 15055, 16676, 159, 163, 234, 138, 186, 53, 60, 33)]
  internal interface ICoreTouchHitTesting
  {
    event TypedEventHandler<object, TouchHitTestingEventArgs> TouchHitTesting;
  }
}
