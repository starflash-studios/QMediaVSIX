// Decompiled with JetBrains decompiler
// Type: Windows.System.IDispatcherQueue2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(3357722183, 12527, 20590, 189, 30, 166, 71, 174, 102, 117, 255)]
  [ExclusiveTo(typeof (DispatcherQueue))]
  internal interface IDispatcherQueue2
  {
    bool HasThreadAccess { get; }
  }
}
