// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2521705277, 60455, 18568, 179, 206, 199, 75, 65, 132, 35, 173)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  internal interface IStreamSocketControl4
  {
    SocketProtectionLevel MinProtectionLevel { get; set; }
  }
}
