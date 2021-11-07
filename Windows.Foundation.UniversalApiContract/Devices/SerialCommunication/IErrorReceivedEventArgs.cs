// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.IErrorReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  [Guid(4240883545, 4739, 19850, 191, 223, 86, 107, 51, 221, 178, 143)]
  [ExclusiveTo(typeof (ErrorReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IErrorReceivedEventArgs
  {
    SerialError Error { get; }
  }
}
