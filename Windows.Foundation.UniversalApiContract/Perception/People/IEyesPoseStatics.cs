// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IEyesPoseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.Perception.People
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (EyesPose))]
  [Guid(486503443, 45599, 21696, 128, 193, 230, 13, 153, 76, 165, 140)]
  internal interface IEyesPoseStatics
  {
    bool IsSupported();

    [RemoteAsync]
    IAsyncOperation<GazeInputAccessStatus> RequestAccessAsync();
  }
}
