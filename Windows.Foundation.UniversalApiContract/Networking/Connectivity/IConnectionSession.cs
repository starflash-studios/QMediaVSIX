// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(4287651148, 63547, 16816, 138, 12, 20, 98, 217, 197, 107, 115)]
  [ExclusiveTo(typeof (ConnectionSession))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectionSession : IClosable
  {
    ConnectionProfile ConnectionProfile { get; }
  }
}
