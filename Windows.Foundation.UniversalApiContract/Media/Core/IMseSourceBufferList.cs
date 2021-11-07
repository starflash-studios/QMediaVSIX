// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseSourceBufferList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MseSourceBufferList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2516248807, 43239, 20159, 137, 39, 20, 94, 148, 11, 165, 17)]
  [WebHostHidden]
  internal interface IMseSourceBufferList
  {
    event TypedEventHandler<MseSourceBufferList, object> SourceBufferAdded;

    event TypedEventHandler<MseSourceBufferList, object> SourceBufferRemoved;

    IVectorView<MseSourceBuffer> Buffers { get; }
  }
}
