// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.DialProtocol
{
  [Guid(3132617685, 23547, 20154, 139, 50, 181, 124, 92, 94, 229, 201)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (DialDevice))]
  internal interface IDialDevice2
  {
    string FriendlyName { get; }

    IRandomAccessStreamReference Thumbnail { get; }
  }
}
