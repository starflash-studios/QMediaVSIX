// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoSequenceCapture2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ExclusiveTo(typeof (VariablePhotoSequenceCapture))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4264321724, 20656, 17379, 145, 124, 227, 185, 39, 152, 148, 47)]
  internal interface IVariablePhotoSequenceCapture2
  {
    [RemoteAsync]
    IAsyncAction UpdateSettingsAsync();
  }
}
