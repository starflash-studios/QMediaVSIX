// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.IPreallocatedWorkItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [Guid(3067783676, 48219, 16410, 168, 178, 110, 117, 77, 20, 218, 166)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PreallocatedWorkItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPreallocatedWorkItem
  {
    [RemoteAsync]
    IAsyncAction RunAsync();
  }
}
