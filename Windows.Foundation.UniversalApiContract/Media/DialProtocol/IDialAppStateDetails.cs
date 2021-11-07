// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialAppStateDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialAppStateDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3720651937, 62942, 16397, 190, 164, 140, 132, 102, 187, 41, 97)]
  internal interface IDialAppStateDetails
  {
    DialAppState State { get; }

    string FullXml { get; }
  }
}
