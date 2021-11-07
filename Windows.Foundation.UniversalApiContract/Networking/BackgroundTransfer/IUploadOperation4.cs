// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUploadOperation4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(1357770545, 64197, 16878, 176, 48, 220, 119, 202, 238, 159, 170)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (UploadOperation))]
  internal interface IUploadOperation4
  {
    void SetRequestHeader(string headerName, string headerValue);

    void RemoveRequestHeader(string headerName);
  }
}
