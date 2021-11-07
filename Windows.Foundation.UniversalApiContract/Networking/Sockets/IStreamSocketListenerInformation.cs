// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(3861620783, 42554, 17163, 191, 98, 41, 233, 62, 86, 51, 180)]
  [ExclusiveTo(typeof (StreamSocketListenerInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListenerInformation
  {
    string LocalPort { get; }
  }
}
