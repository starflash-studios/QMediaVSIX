// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(551077238, 36234, 19898, 151, 34, 161, 108, 77, 152, 73, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketListenerControl))]
  internal interface IStreamSocketListenerControl
  {
    SocketQualityOfService QualityOfService { get; set; }
  }
}
