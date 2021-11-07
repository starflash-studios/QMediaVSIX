// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Gaming.Input.Custom
{
  [Guid(3687783961, 6901, 17832, 191, 2, 160, 238, 80, 200, 35, 252)]
  [ExclusiveTo(typeof (GipGameControllerProvider))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IGipGameControllerProvider : IGameControllerProvider
  {
    void SendMessage(GipMessageClass messageClass, byte messageId, byte[] messageBuffer);

    void SendReceiveMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] requestMessageBuffer,
      [Out] byte[] responseMessageBuffer);

    [RemoteAsync]
    IAsyncOperationWithProgress<GipFirmwareUpdateResult, GipFirmwareUpdateProgress> UpdateFirmwareAsync(
      IInputStream firmwareImage);
  }
}
