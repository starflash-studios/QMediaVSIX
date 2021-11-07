// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4293979567, 30111, 16850, 162, 10, 127, 41, 206, 11, 55, 132)]
  [ExclusiveTo(typeof (DialDevice))]
  internal interface IDialDevice
  {
    string Id { get; }

    DialApp GetDialApp(string appName);
  }
}
