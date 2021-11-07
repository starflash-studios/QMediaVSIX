// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.ISignalNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  [ExclusiveTo(typeof (SignalNotifier))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(338189830, 25511, 18195, 182, 217, 98, 246, 75, 86, 251, 139)]
  internal interface ISignalNotifier
  {
    void Enable();

    void Terminate();
  }
}
