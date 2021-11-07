// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IUssdSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(798674818, 8194, 19805, 191, 129, 42, 186, 27, 75, 228, 168)]
  [ExclusiveTo(typeof (UssdSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUssdSession
  {
    IAsyncOperation<UssdReply> SendMessageAndGetReplyAsync(
      UssdMessage message);

    void Close();
  }
}
