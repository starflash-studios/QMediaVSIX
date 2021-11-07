// Decompiled with JetBrains decompiler
// Type: Windows.System.IDispatcherQueueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2842526679, 37745, 17687, 146, 69, 208, 130, 74, 193, 44, 116)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (DispatcherQueue))]
  internal interface IDispatcherQueueStatics
  {
    DispatcherQueue GetForCurrentThread();
  }
}
