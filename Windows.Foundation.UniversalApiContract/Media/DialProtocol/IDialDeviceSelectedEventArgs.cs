// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DialDeviceSelectedEventArgs))]
  [Guid(1208717997, 44150, 18411, 156, 6, 161, 147, 4, 218, 2, 71)]
  internal interface IDialDeviceSelectedEventArgs
  {
    DialDevice SelectedDialDevice { get; }
  }
}
