// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.Preview.ISoundLevelBrokerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core.Preview
{
  [Guid(1784887649, 56301, 17996, 160, 154, 51, 65, 47, 92, 170, 63)]
  [ExclusiveTo(typeof (SoundLevelBroker))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISoundLevelBrokerStatics
  {
    SoundLevel SoundLevel { get; }

    event EventHandler<object> SoundLevelChanged;
  }
}
